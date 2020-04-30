using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using ZXing.Net.Mobile;

namespace XAOData
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        ZXingScannerPage scanner = new ZXingScannerPage();
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(scanner);

            scanner.OnScanResult += (result) => {

                Device.BeginInvokeOnMainThread(async () => 
                {

                   await Navigation.PopAsync();

                    myScannedCode.Text = result.Text;
                
                });
            
            };

        }
    }
}
