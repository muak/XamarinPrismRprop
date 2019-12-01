using System;
using Prism.Mvvm;
using Reactive.Bindings;

namespace XamarinPrismRprop.ViewModels
{
    public class MainPageViewModel:BindableBase
    {
        public ReactivePropertySlim<string> Text { get; } = new ReactivePropertySlim<string>();

        public MainPageViewModel()
        {
            Text.Value = "Welcome to Xamarin.Forms!";
        }
    }
}
