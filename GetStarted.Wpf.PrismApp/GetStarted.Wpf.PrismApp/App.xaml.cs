using GetStarted.Wpf.PrismApp.Modules.ModuleName;
using GetStarted.Wpf.PrismApp.Services;
using GetStarted.Wpf.PrismApp.Services.Interfaces;
using GetStarted.Wpf.PrismApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace GetStarted.Wpf.PrismApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
