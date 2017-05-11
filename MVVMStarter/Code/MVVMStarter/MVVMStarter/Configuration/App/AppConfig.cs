using System.Reflection;

namespace MVVMStarter.Configuration.App
{
    /// <summary>
    /// Contains application-wide configuration values
    /// (This could be a suitable point for dependency-injection)
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Application-wide constants
        /// </summary>
        public const string ImageFilePrefix = "..\\..\\..\\Assets\\Images\\";
        public const string AppImageFilePrefix = "..\\..\\..\\Assets\\App\\";
        public const string NotSetImageFile = "..\\..\\..\\Assets\\App\\NotSet.jpg";

        public const bool UseLogin = false;
        public static string CurrentUser = Security.App.User.NoUserName;

        /// <summary>
        /// Load/Save delegates
        /// </summary>
        public delegate void SourceDelegate();
        public static SourceDelegate LoadCatalogs = null;
        public static SourceDelegate SaveCatalogs = null;

        /// <summary>
        /// Load in Image and User data
        /// Sets up all catalogs to be included in Load and Save operations
        /// </summary>
        public static void Setup()
        {
            Security.App.Catalog.Instance.Load();
            Images.App.Catalog.Instance.Load();

            foreach (var prop in typeof(Models.App.ObjectProvider).GetProperties())
            {
                prop.GetMethod.Invoke(null, null);
            }
        }

        /// <summary>
        /// Loads all catalogs from storage.
        /// </summary>
        public static void Load()
        {
            LoadCatalogs?.Invoke();
        }

        /// <summary>
        /// Saves all catalogs to storage.
        /// </summary>
        public static void Save()
        {
            SaveCatalogs?.Invoke();
        }
    }
}
