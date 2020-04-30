using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.Views;
using Xamarin.Forms;

namespace XaBarcodeScannerProject.ViewModels 
{
    class LoginViewModel : BaseViewModel
	{
		private string userEmail;
		bool isValid = false;


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

        public Command GetTextCMD => new Command(async () =>
        {
			Console.WriteLine(UserEmail, UserPassword);

			Console.WriteLine(AuthUser(UserEmail, UserPassword));
			await AuthUser(UserEmail, UserPassword);

			if (isValid)
			{
				LoginPassed();
			}
		});

		public async Task AuthUser(string username, string password)
		{
			if (username == "a" && password == "b")
			{
				await App.Current.MainPage.DisplayAlert("Notification", "Success", "Okay");
				
				isValid = true;

			}
		}

		public void LoginPassed()
		{
			App.Current.MainPage = new ScannerPageView();
		}


    }
}
