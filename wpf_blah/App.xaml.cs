using System.Windows;
using Prism.Ioc;
using Prism.Regions;
using wpf_blah.Services;
using wpf_blah.ViewModels;
using wpf_blah.Views;

namespace wpf_blah
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "LoginView");
        }
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IAuthService, AuthService>();

            containerRegistry.RegisterForNavigation<LoginView>();
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterDialog<MyPopupView, MyPopupViewModel>();
        }
    }
}
