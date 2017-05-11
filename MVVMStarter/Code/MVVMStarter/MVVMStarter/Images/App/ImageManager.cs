using System.Collections.Generic;
using System.Linq;
using MVVMStarter.Configuration.App;
using MVVMStarter.Models.App;

namespace MVVMStarter.Images.App
{
    public class ImageManager
    {
        private static Image _notSetImage = new Image("Not set", AppConfig.AppImageFilePrefix + "NotSet.jpg");

        public static List<Image> AllWithTag(string tag)
        {
            var tagFilter = new Filter<Image>(tag, (obj) => obj.ContainsTag(tag));
            tagFilter.On = true;

            Catalog.Instance.AddFilter(tagFilter);
            List<Image> filteredImages = Catalog.Instance.FilteredAll;
            Catalog.Instance.RemoveFilter(tag);

            return filteredImages;
        }

        public static List<string> AllTags
        {
            get
            {
                List<string> allTags = new List<string>();

                foreach (Image img in Catalog.Instance.All)
                {
                    allTags.AddRange(img.Tags);
                }

                return allTags.Distinct().ToList();
            }
        }

        public static Image ReadWithFallback(int key)
        {
            return (Catalog.Instance.Read(key) == null) ? _notSetImage : Catalog.Instance.Read(key);
        }

        public static Image Read(int key)
        {
            return (Catalog.Instance.Read(key));
        }
    }
}
