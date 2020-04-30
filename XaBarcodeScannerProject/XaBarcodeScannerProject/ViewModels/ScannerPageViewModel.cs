using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XaBarcodeScannerProject.Views;

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
              
            }
        }

        public Command Scan => new Command(async () =>
        {
           

        });


    }
}
