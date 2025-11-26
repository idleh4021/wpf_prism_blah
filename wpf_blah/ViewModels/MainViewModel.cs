using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace wpf_blah.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IDialogService _dialogService;
        public DelegateCommand OpenPopupCommand { get; }
        public MainViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            OpenPopupCommand = new DelegateCommand(OpenPopup);

        }

        private void OpenPopup()
        {
            _dialogService.ShowDialog("MyPopupView", null, result =>
            {
                //닫힌 후 처리
            });
        }
    }
}
