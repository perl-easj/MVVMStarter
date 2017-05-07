using MVVMStarter.Models.Base;

/// <summary>
/// NB: THIS CLASS IS OPTIONAL - ONLY DEFINE IT IF YOU NEED TO
///     CREATE DOMAIN OBJECTS DIRECTLY IN THE SOURCE CODE
/// TEMPLATE: You must 
/// 1) Create a file called HardCodedObjects.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain._REPLACEME_
{
    public class HardCodedObjects : HardCodedObjectsBase<_REPLACEME_>
    {
        public HardCodedObjects()
        {
            _REPLACEME_ obj1 = new _REPLACEME_(/* parameters to constructor */);
            obj1.AddTag("T1");
            obj1.AddTag("T2");

            _REPLACEME_ obj2 = new _REPLACEME_(/* parameters to constructor */);
            obj2.AddTag("T2");
            obj2.AddTag("T3");

            ObjectList.Add(obj1);
            ObjectList.Add(obj2);
        }
    }
}
