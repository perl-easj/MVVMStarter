using MVVMStarter.Models.Base;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;

namespace MVVMStarter.Controllers.Base
{
    /// <summary>
    /// Generic handler for Deletion event.
    /// </summary>
    /// <typeparam name="TDomainClass"></typeparam>
    public class DeleteControllerBase<TDomainClass> : ControllerBase<TDomainClass>
        where TDomainClass : DomainClassBase, new()
    {
        public DeleteControllerBase(MasterDetailsViewModelBase<TDomainClass> masterDetailsViewModel,
                                    CatalogBase<TDomainClass> catalog)
            : base(masterDetailsViewModel, catalog)
        {
        }

        public override void Execute()
        {
            TDomainClass obj = MasterDetailsViewModel.ItemViewModelSelected.DomainObject;

            Catalog.Delete(obj.Key);
            MasterDetailsViewModel.AfterModelDelete(obj.Key);
        }

        public override bool CanExecute()
        {
            return (MasterDetailsViewModel.ItemViewModelSelected != null && 
                    MasterDetailsViewModel.ViewState == ViewControlState.ViewState.Delete);
        }
    }
}
