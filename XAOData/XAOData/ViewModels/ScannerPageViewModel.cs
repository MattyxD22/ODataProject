using System;
using System.Collections.Generic;
using System.Text;
using XAOData.Views;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using System.ComponentModel;

namespace XAOData.ViewModels
{
    public class ScannerPageViewModel : BaseViewModel
    {
        private string myScannedCode;

        public string MyScannedCode
        {
            get { return myScannedCode; }
            set
            { myScannedCode = value;
                OnpropertyChanged(nameof(MyScannedCode));
            }
        }
               
        ZXingScannerPage scanner = new ZXingScannerPage();
        public Command Scan => new Command(async () => 
        {
           
           await Navigation.PushAsync(scanner);

            scanner.OnScanResult += (result) => {

                Device.BeginInvokeOnMainThread(async () =>
                {

                  await  Navigation.PopAsync();

                    myScannedCode = result.Text;

                });

            };

        });
    }
}
