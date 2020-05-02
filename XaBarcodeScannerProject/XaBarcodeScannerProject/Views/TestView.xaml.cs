using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XaBarcodeScannerProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestView : ContentPage
    {
        public TestView()
        {
            InitializeComponent();
            BindingContext = new TestViewModel();
        }
    }
}