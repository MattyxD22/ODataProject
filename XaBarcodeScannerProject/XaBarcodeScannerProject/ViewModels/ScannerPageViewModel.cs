using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XaBarcodeScannerProject.Views;
using ZXing.Net.Mobile.Forms;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.SignalR.Client;

namespace XaBarcodeScannerProject.ViewModels
{
   public class ScannerPageViewModel : BaseViewModel
    {
        Microsoft.AspNetCore.SignalR.Client.HubConnection hubConnection;
        public ScannerPageViewModel()
        {
            BasketCMD = new Command(async () => { await AddScannedItem(ScannedCode); });

            hubConnection = new HubConnectionBuilder()
            .WithUrl("https://projectnavision20200502131207.azurewebsites.net/chatHub")
            .Build();
        }

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

        public Command BasketCMD { get; }

        public async Task AddScannedItem(string barcode)
        {
            //Call the code unit from the hubclass
            //await hubconnection.InvokeAsync();
        }


    }
}
