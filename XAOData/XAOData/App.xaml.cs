using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAOData.Views;

namespace XAOData
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ScannerPage());

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
