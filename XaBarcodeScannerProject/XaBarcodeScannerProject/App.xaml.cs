using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XaBarcodeScannerProject.Views;

namespace XaBarcodeScannerProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistrationView());
            //MainPage = new NavigationPage(new RecieptView());
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
