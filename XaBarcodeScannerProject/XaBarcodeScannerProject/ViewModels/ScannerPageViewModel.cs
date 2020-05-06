using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XaBarcodeScannerProject.Views;
using ZXing.Net.Mobile.Forms;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace XaBarcodeScannerProject.ViewModels
{
   public class ScannerPageViewModel : BaseViewModel
    {
        HubConnection hubConnection;
        public ScannerPageViewModel()
        {
            BasketCMD = new Command(async () => { await AddScannedItem(ScannedCode); });


            hubConnection = new HubConnectionBuilder()
            .WithUrl("https://localhost:5000/Controllers")
            .Build();

            //Connect to the backend
            //Connect();

            //Event handlers from events that are fired from the backend
            hubConnection.On<string>("ItemName", (itemName) =>
            {
                Console.WriteLine(itemName);
                ScannedItem = itemName;

            });

            hubConnection.On<string>("ItemPrice", (itemPrice) =>
            {
                Console.WriteLine(itemPrice);
                ScannedPrice = itemPrice;

            });

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

        private string scannedItem;

        public string ScannedItem
        {
            get { return scannedItem; }
            set { scannedItem = value; }
        }

        private string scannedPrice;

        public string ScannedPrice
        {
            get { return scannedPrice; }
            set { scannedPrice = value; }
        }

        public async void OnScanClicked(ZXing.Result result)
        {
            ScannedCode = result.Text;
        }

        public Command BasketCMD { get; }

        public async Task AddScannedItem(string barcode)
        {
            //Call the code unit from the hubclass
            //await hubconnection.InvokeAsync("ItemName", barcode);
            //await hubconnection.InvokeAsync("ItemPrice", barcode);
        }

        async Task Connect()
        {
            try
            {
                await hubConnection.StartAsync();
                Console.WriteLine("Is connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("ConnectMethod Error: " + e.Message);
               
            }
        }

    }
}
