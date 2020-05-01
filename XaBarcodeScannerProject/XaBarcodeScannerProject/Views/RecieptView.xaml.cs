using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.ViewModels;
using XaBarcodeScannerProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XaBarcodeScannerProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecieptView : ContentPage
    {
        public RecieptView()
        {
            InitializeComponent();
            var viewmodel = new RecieptViewModel();
            BindingContext = viewmodel;
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