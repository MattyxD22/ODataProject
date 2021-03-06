﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.Models;
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
                        // lukker scanneren når den har fået et resultat. 
                        await Navigation.PopAsync();
                        
                        
                    });
                };
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            var button = sender as Button;
            var product = button?.BindingContext as ProductsModel;
            var vm = BindingContext as RecieptViewModel;
            vm?.DelteItem.Execute(product);
        }

    }
}