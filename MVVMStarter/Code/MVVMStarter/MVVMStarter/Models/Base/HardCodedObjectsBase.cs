using System.Collections.Generic;

namespace MVVMStarter.Models.Base
{
    public class HardCodedObjectsBase<TDomainClass>
    {
        private List<TDomainClass> _objectList;

        public List<TDomainClass> ObjectList
        {
            get { return _objectList; }
        }

        public HardCodedObjectsBase()
        {
            _objectList = new List<TDomainClass>();
        }
    }
}