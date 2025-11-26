using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using wpf_blah.Services;

namespace wpf_blah.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly IAuthService _authService;
        private readonly IRegionManager _regionManager;

        public DelegateCommand LoginCommand { get; }
       
        public LoginViewModel(IAuthService authService, IRegionManager regionManager)
        {
            _authService = authService;
            _regionManager = regionManager;
            LoginCommand = new DelegateCommand(OnLogin);
        }

        private string _userId;
        public string UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private void OnLogin()
        {
           if(_authService.Login(UserId,Password))
           {
                _regionManager.RequestNavigate("ContentRegion", "MainView");
           }
           else
           {
                Console.WriteLine("실패");
           }
        }
    }
}
