using System.Collections.Generic;
using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.Base;
using _REPLACEME_Class = MVVMStarter.Models.Domain._REPLACEME_._REPLACEME_;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called MasterDetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
namespace MVVMStarter.ViewModels.Domain._REPLACEME_
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<_REPLACEME_Class>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider._REPLACEME_Catalog)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls. The names used in the calls
            //// of Add must match the names used in the view.xaml file for 
            //// getting the Description, Visibility and Enabled state for each control

            //List<string> fixedProperties = new List<string>();
            //// Add names of "fixed" (cannot be changed after creation) view properties here
            //fixedProperties.Add("FixedPropertyA");
            //fixedProperties.Add("FixedPropertyB");
            //fixedProperties.Add("FixedPropertyC");

            //List<string> nonFixedKeyProperties = new List<string>();
            //// Add names of "non-fixed" (can be changed after creation) view properties here
            //nonFixedKeyProperties.Add("NonFixedPropertyD");
            //nonFixedKeyProperties.Add("NonFixedPropertyE");

            //StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            //StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            //StateManager.AddButtonDefaultStates();
        }
    }
}
