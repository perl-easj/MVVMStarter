using System;
using System.Collections.Generic;
using MVVMStarter.Models.App;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Base
{
    /// <summary>
    /// Base class for a catalog. A catalog is defined as a collection 
    /// of domain objects, plus a source for retrieving the domain objects.
    /// </summary>
    /// <typeparam name="TDomainClass">
    /// Type of specific domain object for which this is a catalog
    /// </typeparam>
    public class CatalogBase<TDomainClass> where TDomainClass : DomainClassBase
    {
        private CollectionBase<TDomainClass> _collection;
        private SourceBase<TDomainClass> _source;
        private FilterManager<TDomainClass> _filterManager;
        private bool _modified;

        // private Dictionary<string, Filter<TDomainClass>> _filters;

        /// <summary>
        /// Sets up the catalog as a paired collection and source
        /// </summary>
        /// <param name="collection">
        /// In-memory collection of domain objects
        /// </param>
        /// <param name="source"></param>
        /// Source for loading/saving domain objects
        /// <param name="loadWhenCreated"></param>
        public CatalogBase(CollectionBase<TDomainClass> collection,
                           SourceBase<TDomainClass> source,
                           bool loadWhenCreated = false)
        {
            // Sanity checks, so we don't need null checks elsewhere
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (source == null) throw new ArgumentNullException(nameof(source));

            _source = source;
            _collection = collection;
            _filterManager = new FilterManager<TDomainClass>();

            Modified = true;

            if (loadWhenCreated)
            {
                Load();
            }      
        }

        public void AddFilter(Filter<TDomainClass> filter)
        {
            _filterManager.Add(filter);
        }

        public void RemoveFilter(string filterID)
        {
            _filterManager.RemoveFilter(filterID);
        }

        public List<TDomainClass> FilteredAll
        {
            get { return _filterManager.FilterList(All); }
        }

        /// <summary>
        /// Returns a List containing all domain objects
        /// </summary>
        public List<TDomainClass> All
        {
            get { return _collection.All; }
        }

        /// <summary>
        /// Returns whether the catalog has been changed
        /// </summary>
        public bool Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }

        /// <summary>
        /// Inserts a single domain object into the catalog
        /// </summary>
        /// <param name="obj">
        /// Domain object to insert
        /// </param>
        public void Insert(TDomainClass obj)
        {
            _collection.Insert(obj);
            Modified = true;
        }

        /// <summary>
        /// Deletes a single domain object from the catalog
        /// </summary>
        /// <param name="key">
        /// Key for object to delete.
        /// </param>
        /// <returns>
        /// Returns true if an object was actually deleted.
        /// </returns>
        public bool Delete(int key)
        {
            Modified = _collection.Delete(key);
            return Modified;
        }

        /// <summary>
        /// Deletes all domain objects from the catalog unconditionally.
        /// </summary>
        public void DeleteAll()
        {
            _collection.DeleteAll();
        }

        /// <summary>
        /// Retrieves the object corresponding to the given key
        /// </summary>
        /// <param name="key">Key of object to retrieve</param>
        /// <returns>The domain object corresponding to the given key</returns>
        public TDomainClass Read(int key)
        {
            return _collection.Read(key);
        }

        /// <summary>
        /// Loads domain objects from the source.
        /// NB: Note that exceptions are catched and ignored
        /// </summary>
        public async void Load()
        {
            try
            {
                _collection = await _source.Load();
            }
            catch (Exception)
            {
                // ignored
            }
            Modified = true;
        }

        /// <summary>
        /// Saves domain objects back to the source.
        /// </summary>
        public void Save()
        {
            _source.Save(_collection);
        }
    }
}
