using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace XaBarcodeScannerProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerPageView : ContentPage
    {
        public ScannerPageView()
        {
            InitializeComponent();
            BindingContext = new ScannerPageViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();

            await Navigation.PushAsync(scan);

            scan.OnScanResult += (result) =>
                {
                   ((ScannerPageViewModel)this.BindingContext).OnScanClicked(result); // sender result til viewmodel så man kan "arbejde" videre med barcoden
                    Device.BeginInvokeOnMainThread(async () =>
                    {

                        await Navigation.PopAsync();
                        
                        
                    });
                };
        }
       
    }
}