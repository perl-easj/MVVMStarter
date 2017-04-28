using MVVMStarter.Models.Base;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;

namespace MVVMStarter.Controllers.Base
{
    /// <summary>
    /// Generic handler for Insertion event.
    /// </summary>
    /// <typeparam name="TDomainClass"></typeparam>
    public class CreateControllerBase<TDomainClass> : ControllerBase< TDomainClass>
        where TDomainClass : DomainClassBase, new()
    {
        public CreateControllerBase(MasterDetailsViewModelBase<TDomainClass> masterDetailsViewModel,
                                    CatalogBase<TDomainClass> catalog)
            : base(masterDetailsViewModel, catalog)
        {
        }

        public override void Execute()
        {
            TDomainClass obj = (TDomainClass)MasterDetailsViewModel.DetailsViewModel.DomainObject.Clone();

            Catalog.Insert(obj);
            MasterDetailsViewModel.AfterModelInsert(obj);
        }

        public override bool CanExecute()
        {
            return (MasterDetailsViewModel.ViewState == ViewControlState.ViewState.Create);
        }
    }
}
