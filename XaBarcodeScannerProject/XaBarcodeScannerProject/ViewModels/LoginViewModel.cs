using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
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

		Microsoft.AspNetCore.SignalR.Client.HubConnection hubConnection;

		public LoginViewModel()
		{
			hubConnection = new HubConnectionBuilder()
			.WithUrl("https://projectnavision20200502131207.azurewebsites.net/chatHub")
			.Build();
			Connect();
		}


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

		async Task Connect()
		{
			try
			{
				Console.WriteLine("Is connected");
				await hubConnection.StartAsync();

				//call the LoginMethod from the hubClass
				//await hubConnection.InvokeAsync("Echo", user, message);

				//
			}
			catch (Exception e)
			{
				Console.WriteLine("ConnectMethod Error: " + e.Message);
			}

		}
	}
}
