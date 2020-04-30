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

        public async void OnScanClicked(ZXing.Result result)
        {
            ScannedCode = result.Text;
        }

    }
}
