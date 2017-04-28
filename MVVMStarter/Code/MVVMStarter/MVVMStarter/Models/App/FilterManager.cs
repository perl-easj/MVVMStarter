using System.Collections.Generic;

namespace MVVMStarter.Models.App
{
    public class FilterManager<TDomainClass>
    {
        private Dictionary<string, Filter<TDomainClass>> _filters;
        public FilterManager()
        {
            _filters = new Dictionary<string, Filter<TDomainClass>>();
        }

        public void Add(Filter<TDomainClass> filter)
        {
            if (!_filters.ContainsKey(filter.ID))
            {
                _filters.Add(filter.ID, filter);
            }
        }

        public void RemoveFilter(string filterID)
        {
            _filters.Remove(filterID);
        }

        public List<TDomainClass> FilterList(List<TDomainClass> list)
        {
            return list.FindAll(SatisfiesAll);
        }

        public bool SatisfiesAll(TDomainClass obj)
        {
            foreach (var filter in _filters.Values)
            {
                if (!filter.Condition(obj)) return false;
            }

            return true;
        }
    }
}