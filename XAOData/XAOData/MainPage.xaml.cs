using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace XAOData
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var scanner = new ZXingScannerPage();
            Navigation.PushAsync(scanner);

            scanner.OnScanResult += (result) => {

                Device.BeginInvokeOnMainThread(async () => 
                {

                    Navigation.PopAsync();

                    myScannedCode.Text = result.Text;
                
                });
            
            };

        }
    }
}
