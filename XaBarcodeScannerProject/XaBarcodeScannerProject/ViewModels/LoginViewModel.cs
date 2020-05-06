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

		HubConnection hubConnection;

		public LoginViewModel()
		{
			CreateNewUserCMD = new Command(async () => { await CreateUser(); });
			

			hubConnection = new HubConnectionBuilder()
			.WithUrl("https://localhost:5000/Controllers")
			.Build();

			//since connection cant be made the Connect() method gets outcommented
			//Connect();

			hubConnection.On<string>("LoginCU", (reply) =>
			{
				Console.WriteLine("Loggin passed");
				//LoginPassed();
			});

		}

		public Command CreateNewUserCMD { get; }

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
			//Test/debug condition
			if (username == "a" && password == "b")
			{
				//call the LoginMethod from the hubClass
				//await hubConnection.InvokeAsync("LoginCU", username, password);

				//Should normally be handled by an event
				await App.Current.MainPage.DisplayAlert("Notification", "Success", "Okay");
				
				isValid = true;

				//The connection should probably be closed again
				//await hubConnection.StopAsync();
			}
		}

		async Task CreateUser()
		{

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

			}
			catch (Exception e)
			{
				Console.WriteLine("ConnectMethod Error: " + e.Message);
			}

		}
	}
}
