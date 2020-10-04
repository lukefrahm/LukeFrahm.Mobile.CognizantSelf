using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LukeFrahm.Mobile.CognizantSelf.Shared.Services;
using LukeFrahm.Mobile.CognizantSelf.Shared.Views;

namespace LukeFrahm.Mobile.CognizantSelf.Shared
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
