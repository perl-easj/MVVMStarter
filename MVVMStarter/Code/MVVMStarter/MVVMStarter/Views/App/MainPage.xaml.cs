using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MVVMStarter.Common;
using MVVMStarter.Configuration.App;
using MVVMStarter.Security.App;

#pragma warning disable CS4014

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVVMStarter.Views.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppConfig.Setup();
            AppFrame.Navigate(typeof(OpeningView));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            AppSplitView.IsPaneOpen = !AppSplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // if (_REPLACEME_View.IsSelected)
            // {
            //     TryNavigate(typeof(Domain._REPLACEME_.View, "_REPLACEME_View"));
            // }
            if (ImageView.IsSelected)
            {
                AppFrame.Navigate(typeof(App.ImageView));
            }
            string nameOfSelection = ((ListBoxItem)e.AddedItems[0]).Name;
            if (nameOfSelection == "Login")
            {
                AppFrame.Navigate(typeof(App.LoginView));
            }
            if (nameOfSelection == "Load")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to LOAD model data?", "LOAD", new RelayCommand(AppConfig.Load));
            }
            if (nameOfSelection == "Save")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to SAVE model data?", "SAVE", new RelayCommand(AppConfig.Save));
            }
            if (nameOfSelection == "Quit")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to QUIT?", "QUIT", new RelayCommand(Application.Current.Exit));
            }
        }

        private void TryNavigate(System.Type viewType, string viewName)
        {
            if (AccessManager.CanAccessItem(viewName))
            {
                AppFrame.Navigate(viewType);
            }
            else
            {
                UserActionPresenter.PresentMessageNoAction("You do not have access to the " + viewName, "OK");
            }
        }
    }
}
