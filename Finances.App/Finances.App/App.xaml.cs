using Finances.App.Helpers.Messaging;
using Finances.App.Helpers.Navigation;
using Finances.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finances.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<INavigationService, NavigationService>();

            MainPage = new SignIn();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
