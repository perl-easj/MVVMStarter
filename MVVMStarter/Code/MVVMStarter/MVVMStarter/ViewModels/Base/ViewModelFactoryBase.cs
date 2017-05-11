using System.Collections.ObjectModel;
using MVVMStarter.Models.Base;

namespace MVVMStarter.ViewModels.Base
{
    public abstract class ViewModelFactoryBase<TDomainClass>
        where TDomainClass : DomainClassBase, new()
    {
        public abstract DetailsViewModelBase<TDomainClass> CreateDetailsViewModel(TDomainClass obj);
        public abstract ItemViewModelBase<TDomainClass> CreateItemViewModel(TDomainClass obj);

        public DetailsViewModelBase<TDomainClass> CreateDetailsViewModelFromNew()
        {
            return CreateDetailsViewModel(new TDomainClass());
        }

        public DetailsViewModelBase<TDomainClass> CreateDetailsViewModelFromClone(TDomainClass obj)
        {
            return CreateDetailsViewModel((TDomainClass)obj.Clone());
        }

        public virtual ObservableCollection<ItemViewModelBase<TDomainClass>> CreateItemViewModelCollection(
            CatalogBase<TDomainClass> catalog, ViewModelFactoryBase<TDomainClass> factory)
        {
            var obsColl = new ObservableCollection<ItemViewModelBase<TDomainClass>>();

            foreach (TDomainClass obj in catalog.FilteredAll)
            {
                obsColl.Add(CreateItemViewModel(obj));
            }

            return obsColl;
        }
    }
}
