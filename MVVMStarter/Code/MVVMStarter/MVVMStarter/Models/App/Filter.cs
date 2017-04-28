namespace MVVMStarter.Models.App
{
    public class Filter<TDomainClass>
    {
        public delegate bool FilterCondition(TDomainClass obj);

        public bool On;
        private string _id;
        private FilterCondition _filter;

        public Filter(string id, FilterCondition filter)
        {
            _id = id;
            _filter = filter;
            On = false;
        }

        public string ID { get { return _id; } }

        public void Toggle() { On = !On; }

        public bool Condition(TDomainClass obj) { return !On || _filter(obj); }
    }
}