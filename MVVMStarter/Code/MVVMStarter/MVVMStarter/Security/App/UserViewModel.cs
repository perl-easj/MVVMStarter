using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI.Xaml;
using MVVMStarter.Common;
using MVVMStarter.Configuration.App;
// ReSharper disable UnreachableCode

namespace MVVMStarter.Security.App
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private RelayCommand _loginCommand;

        public UserViewModel()
        {
            _username = User.NoUserName;
            _password = "";
            _loginCommand = new RelayCommand(DoLogin, CanLogin);
        }

        public Visibility LoginVisible
        {
            get { return AppConfig.UseLogin ? Visibility.Visible : Visibility.Collapsed; }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
                _loginCommand.RaiseCanExecuteChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
                _loginCommand.RaiseCanExecuteChanged();
            }
        }

        public string Status
        {
            get { return AccessManager.CurrentUser != null ? AccessManager.CurrentUser.ToString() : "(none)"; }
        }

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
        }

        public void DoLogin()
        {
            AppConfig.CurrentUser = _username;
            OnPropertyChanged(nameof(Status));
        }

        public bool CanLogin()
        {
            return AccessManager.GetUser(_username).Password == _password;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}