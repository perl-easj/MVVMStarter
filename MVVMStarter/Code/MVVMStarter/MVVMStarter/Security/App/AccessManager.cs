using System.Collections.Generic;
using MVVMStarter.Configuration.App;

namespace MVVMStarter.Security.App
{
    public class AccessManager
    {
        private static List<ItemAccess.AccessType> _adminAccessTypes = new List<ItemAccess.AccessType> { ItemAccess.AccessType.Admin };

        public static bool CanAccessItem(string itemName)
        {
            if (!AppConfig.UseLogin || AppConfig.CurrentUser == User.AdminName)
            {
                return true;
            }

            if (CurrentUser != null)
            {
                return CurrentUser.Access(itemName);
            }

            return false;
        }

        public static List<ItemAccess.AccessType> AccessTypesForCurrentUser(string itemName)
        {
            if (!AppConfig.UseLogin || AppConfig.CurrentUser == User.AdminName)
            {
                return _adminAccessTypes;
            }

            if (CurrentUser != null)
            {
                return CurrentUser.GetAccessTypes(itemName);
            }

            return new List<ItemAccess.AccessType>();
        }

        public static User GetUser(string userName)
        {
            List<User> match = Catalog.Instance.All.FindAll(user => user.Name == userName);
            return (match.Count > 0) ? match[0] : new User();
        }

        public static User CurrentUser
        {
            get { return GetUser(AppConfig.CurrentUser); }
        }
    }
}
