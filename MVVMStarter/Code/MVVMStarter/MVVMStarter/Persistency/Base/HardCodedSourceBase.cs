using System.Threading.Tasks;
using MVVMStarter.Models.Base;
#pragma warning disable 1998

namespace MVVMStarter.Persistency.Base
{
    class HardCodedSourceBase<TDomainClass> : SourceBase<TDomainClass>
        where TDomainClass : DomainClassBase
    {
        private HardCodedObjectsBase<TDomainClass> _objects;

        public HardCodedSourceBase(HardCodedObjectsBase<TDomainClass> objects)
        {
            _objects = objects;
        }

        public override async Task<CollectionBase<TDomainClass>> Load()
        {
            CollectionBase<TDomainClass> collection = new CollectionBase<TDomainClass>();

            foreach (var obj in _objects.ObjectList)
            {
                collection.Insert(obj);
            }

            return collection;
        }

        public override void Save(CollectionBase<TDomainClass> collection)
        {
            // Intentionally do nothing...
        }
    }
}
