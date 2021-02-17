using Caliburn.Micro;

namespace RMWPFPresentation.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _password;
        private string _userName;

        public bool CanLogIn => UserName?.Length > 0 && Password?.Length > 0;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                NotifyOfPropertyChange(nameof(UserName));
                NotifyOfPropertyChange(nameof(CanLogIn));
            }
        }

        public void LogIn()
        {
        }
    }
}