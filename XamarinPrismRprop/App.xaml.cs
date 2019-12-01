using System;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using XamarinPrismRprop.ViewModels;
using Prism;
using XamarinPrismRprop.Views;

namespace XamarinPrismRprop
{
    public partial class App:PrismApplication
    {
        public App(IPlatformInitializer initializer):base(initializer)
        {
            InitializeComponent();
        }

        protected override async void OnInitialized()
        {
            var result = await NavigationService.NavigateAsync("MainPage");

            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
