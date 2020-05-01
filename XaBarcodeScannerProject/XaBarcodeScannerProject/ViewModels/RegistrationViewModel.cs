using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XaBarcodeScannerProject.Views;
using Xamarin.Forms;

namespace XaBarcodeScannerProject.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
      
        public Command GoBack => new Command(async () => {
            Console.WriteLine("VIRKER DET");
            // navigate back to login page            
             App.Current.MainPage = new LoginView();
           
        });
    }
}
