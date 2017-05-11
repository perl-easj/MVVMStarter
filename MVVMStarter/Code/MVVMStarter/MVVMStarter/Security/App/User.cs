using System.Collections.Generic;
using MVVMStarter.Models.Base;

namespace MVVMStarter.Security.App
{
    public class User : DomainClassBase
    {
        public static string AdminName = "admin";
        public static string AdminPassword = "admin";

        public static string NoUserName = "(none)";
        public static string NoUserPassword = "(none)";

        private string _name;
        private string _password;
        private ItemAccess _itemAccess;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public override void SetDefaultValues()
        {
            _name = NoUserName;
            _password = NoUserPassword;
        }

        public User()
        {
            SetDefaultValues();
            _itemAccess = new ItemAccess();
        }

        public User(string name, string password)
        {
            _name = name;
            _password = password;
            _itemAccess = new ItemAccess();
        }

        public List<ItemAccess.AccessType> GetAccessTypes(string itemName)
        {
            return _itemAccess.GetAccessTypes(itemName);
        }

        public void Add(string itemName, ItemAccess.AccessType accessType)
        {
            _itemAccess.Add(itemName, accessType);
        }

        public bool Access(string itemName)
        {
            return _name == User.AdminName || _itemAccess.Access(itemName);
        }

        public bool Access(string itemName, ItemAccess.AccessType accessType)
        {
            return _name == User.AdminName || _itemAccess.Access(itemName, accessType);
        }

        public override string ToString()
        {
            string toStr = "User :  " + _name + "\n";
            toStr = toStr + _itemAccess;
            return toStr;
        }
    }
}
