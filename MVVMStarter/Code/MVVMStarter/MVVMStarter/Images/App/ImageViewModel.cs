using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMStarter.Images.App
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        private Image _imageSelected;
        private int _tagSelectedIndex;

        public ImageViewModel()
        {
            _imageSelected = null;
            _tagSelectedIndex = 0;
        }

        public ObservableCollection<Image> ImageCollection
        {
            get
            {
                var collection = new ObservableCollection<Image>();
                if (_tagSelectedIndex == 0)
                {
                    Catalog.Instance.All.ForEach(collection.Add);
                }
                else
                {
                    Catalog.Instance.AllWithTag(Catalog.Instance.AllTags[_tagSelectedIndex - 1]).ForEach(collection.Add);
                }
                return collection;
            }
        }

        public Image ImageSelected
        {
            get { return _imageSelected; }
            set
            {
                _imageSelected = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ImageSelectedDescription));
                OnPropertyChanged(nameof(ImageSelectedTags));
            }
        }

        public string ImageSelectedDescription
        {
            get { return _imageSelected != null ? _imageSelected.Description : string.Empty; }
        }

        public List<string> ImageSelectedTags
        {
            get { return _imageSelected?.Tags; }
        }

        public List<string> AllTags
        {
            get
            {
                List<string> allTags = new List<string>(Catalog.Instance.AllTags);
                allTags.Insert(0, "(All)");
                return allTags;
            }
        }

        public int TagSelectedIndex
        {
            get { return _tagSelectedIndex; }
            set
            {
                _tagSelectedIndex = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ImageCollection));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}