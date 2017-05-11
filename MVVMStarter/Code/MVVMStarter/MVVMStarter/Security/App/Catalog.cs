using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Security.App
{
    public class Catalog : CatalogBase<User>
    {
        #region Model Singleton implementation
        private static Catalog _instance = null;

        public static Catalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new Catalog();
                return _instance;
            }
        }

        /// <summary>
        /// Use a hard-coded source
        /// </summary>
        private Catalog() : base(new CollectionBase<User>(), new HardCodedSourceBase<User>(new HardCodedObjects()))
        {
        }
        #endregion
    }
}