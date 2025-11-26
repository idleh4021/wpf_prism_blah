using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace wpf_blah.ViewModels
{
    public class MyPopupViewModel : BindableBase,IDialogAware
    {
        public string Title { get; set; } = "My Popup";
        
        public event Action<IDialogResult> RequestClose;

        public DelegateCommand CloseCommand { get; }

        public MyPopupViewModel()
        {
            CloseCommand = new DelegateCommand(()=>RequestClose?.Invoke(new DialogResult()));
        }

        public bool CanCloseDialog() => true;
        public void OnDialogClosed() { }
        public void OnDialogOpened(IDialogParameters parameters) { }

     
    }
}
