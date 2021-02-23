﻿using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using RMWPFPresentation.Helpers;

namespace RMWPFPresentation.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _password;
        private string _userName;
        private readonly IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

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

        public async Task LogIn()
        {

            try
            {
                var result = await _apiHelper.Authenticate(UserName, Password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}