using System.Reflection;
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
        public const string NotSetImageFile = "..\\..\\..\\Assets\\App\\NotSet.jpg";

        public delegate void SourceDelegate();
        public static SourceDelegate LoadCatalogs = null;
        public static SourceDelegate SaveCatalogs = null;

        /// <summary>
        /// Sets up all catalogs to be included in Load and Save operations
        /// </summary>
        public static void Setup()
        {
            foreach (var prop in typeof(ObjectProvider).GetProperties())
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
