using MVVMStarter.Models.App;

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
        public const string ImageFilePrefix = "..\\..\\..\\Assets\\Domain\\";
        public const string AppImageFilePrefix = "..\\..\\..\\Assets\\App\\";
        public const string ImageFilePostfix = ".jpg";

        public delegate void SourceDelegate();
        public static SourceDelegate LoadCatalogs = null;
        public static SourceDelegate SaveCatalogs = null;

        /// <summary>
        /// Sets up all catalogs to be included in Load and Save operations
        /// </summary>
        public static void Setup()
        {
            LoadCatalogs += ObjectProvider.ImageCatalog.Load;
            SaveCatalogs += ObjectProvider.ImageCatalog.Save;

            // Add Load and Save methods for new domain classes here
            // LoadCatalogs += ObjectProvider._REPLACEME_Catalog.Load;
            // SaveCatalogs += ObjectProvider._REPLACEME_Catalog.Save;
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
