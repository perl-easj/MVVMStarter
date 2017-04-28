using MVVMStarter.ViewModels.Base;
using _REPLACEME_Class = MVVMStarter.Models.Domain._REPLACEME_._REPLACEME_;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called ItemViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain._REPLACEME_
{
    public class ItemViewModel : ItemViewModelBase<_REPLACEME_Class>
    {
        // Override any of the below properties, if you wish to
        // replace the default implementation with your own
        // (the below examples contain the default implementation)
        //
        //public override string Description
        //{
        //    get { return DomainObject.ToString(); }
        //}

        //public override int FontSize
        //{
        //    get { return 18; }
        //}

        //public override string ImageSource
        //{
        //    get { return String.Empty; }
        //}

        //public override int ImageSize
        //{
        //    get { return 80; }
        //}

        //public override bool ImageIsVisible
        //{
        //    get { return true; }
        //}

        public ItemViewModel(_REPLACEME_Class obj) : base(obj)
        {
        }
    }
}
