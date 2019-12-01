﻿using Prism.Ioc;
using Xamarin.Forms;
using Prism.Unity;
using Prism;
using Sample.Views;
using Sample.ViewModels;

namespace Sample
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
