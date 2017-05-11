using System.Collections.Generic;

namespace MVVMStarter.Security.App
{
    public class ItemAccess
    {
        public enum AccessType
        {
            Create, Read, Update, Delete, Full, Admin
        }

        private Dictionary<string, List<AccessType>> _accessDictionary;

        public ItemAccess()
        {
            _accessDictionary = new Dictionary<string, List<AccessType>>();
        }

        public List<AccessType> GetAccessTypes(string itemName)
        {
            return _accessDictionary.ContainsKey(itemName) ? _accessDictionary[itemName] : new List<AccessType>();
        }

        public void Add(string itemName, AccessType accessType)
        {
            // Add the item, if not already present
            if (!_accessDictionary.ContainsKey(itemName))
            {
                _accessDictionary.Add(itemName, new List<AccessType>());
            }

            // Add the access type, if not already present
            if (!_accessDictionary[itemName].Contains(accessType))
            {
                _accessDictionary[itemName].Add(accessType);
            }
        }

        public bool Access(string itemName)
        {
            return _accessDictionary.ContainsKey(itemName);
        }

        public bool Access(string itemName, AccessType accessType)
        {
            if (_accessDictionary.ContainsKey(itemName))
            {
                if (_accessDictionary[itemName].Contains(AccessType.Full))
                {
                    return true;
                }
                return _accessDictionary[itemName].Contains(accessType);
            }
            return false;
        }

        public override string ToString()
        {
            string toStr = "";

            foreach (var item in _accessDictionary)
            {
                toStr = toStr + item.Key + " { ";

                foreach (var access in item.Value)
                {
                    toStr = toStr + access.ToString() + " ";
                }

                toStr = toStr + "}\n";
            }

            return toStr;
        }
    }
}