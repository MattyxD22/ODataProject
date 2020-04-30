using System;
using System.Collections.Generic;
using System.Text;
using XaBarcodeScannerProject.Views;
using Xamarin.Forms;

namespace XaBarcodeScannerProject.ViewModels 
{
    class LoginViewModel : BaseViewModel
	{
		private string userEmail;

		public string UserEmail
		{
			get { return userEmail; }
			set { userEmail = value; OnPropertyChanged(); }
		}

		private string userPassword;

		public string UserPassword
		{
			get { return userPassword; }
			set { userPassword = value; OnPropertyChanged(); }
		}

        public Command GetTextCommand => new Command(async () =>
        {
			UserEmail = 
			Console.WriteLine();

        });


    }
}
