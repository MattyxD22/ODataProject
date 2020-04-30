using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XaBarcodeScannerProject.Views;
using ZXing.Net.Mobile.Forms;
using System.Threading.Tasks;

namespace XaBarcodeScannerProject.ViewModels
{
   public class ScannerPageViewModel : BaseViewModel
    {
        private string scannedCode;

        public string ScannedCode
        {
            get { return scannedCode; }
            set 
            { scannedCode = value;
              OnPropertyChanged();
            }
        }
        

        public Command Scan => new Command(async () =>
        {
            var scanPage = new ZXingScannerPage();
            
            // Navigate to our scanner page
            await Navigation.PushModalAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert(
                        "Scanned Barcode", result.Text, "OK");
                    
                });
            };

        });


    }
}
