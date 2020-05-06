using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XaBarcodeScannerProject.Views;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace XaBarcodeScannerProject
{
    public partial class App : Application
    {
        public Stopwatch stopWatch = new Stopwatch();
        private const int timeOutMark = 5;

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new RegistrationView());
            MainPage = new NavigationPage(new LoginView());
        }

        protected async override void OnStart()
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
            }

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                // Logic for logging out if the device is inactive for a period of time.
                

                if (stopWatch.IsRunning && stopWatch.Elapsed.Minutes >= timeOutMark)
                {

                    App.Current.MainPage.DisplayAlert("Notification", "You will be logged out for inactivity", "Ok");
                    MainPage = new NavigationPage(new LoginView());

                    stopWatch.Restart();
                }

                // Always return true as to keep our device timer running.
                return true;
            });
        }

        protected override void OnSleep()
        {
            stopWatch.Reset();
        }

        protected override void OnResume()
        {
            stopWatch.Start();
        }

        
    }
}
