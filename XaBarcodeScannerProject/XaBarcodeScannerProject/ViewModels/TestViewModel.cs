using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XaBarcodeScannerProject.ViewModels
{
    public class TestViewModel : BaseViewModel
    {

        HubConnection hubConnection;
        private ObservableCollection<string> _messages;

        public TestViewModel()
        {


            hubConnection = new HubConnectionBuilder()
            .WithUrl("https://projectnavision20200502131207.azurewebsites.net/ChatHub")
            .Build();

            Connect();

            hubConnection.On<string>("CodeUnit", (inputString) =>
            {

                Console.WriteLine("Message has been sent: " + inputString);
                Result = Messages;

                //Messages.Add(new Message() { Username = user, Text = $"{user} has joined the chat", IsSystemMessage = true, Date = DateTime.Now });
            });

            hubConnection.On<string>("JoinChat", (ID) =>
            {
                Console.WriteLine("joined: " + ID);
                
            });
        }

        private string messages;

        public string Messages
        {
            get { return messages; }
            set { messages = value; OnPropertyChanged(); }
        }

        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }

        private int inputID;

        public int InputID
        {
            get { return inputID; }
            set { inputID = value; OnPropertyChanged(); }
        }



        public Command SendMessageCommand => new Command(async () =>
        {
           
            InputID = Int32.Parse(Messages);
            Console.WriteLine(InputID);
            await hubConnection.InvokeAsync("JoinChat", InputID);
            await TestMethod(InputID);

        });

        async Task Connect()
        {
            try
            {
                Console.WriteLine("Is connected");
                await hubConnection.StartAsync();
                await hubConnection.InvokeAsync("JoinChat", 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }

        async Task TestMethod(int ID)
        {
            await hubConnection.InvokeAsync("CodeUnit", ID);
            //await hubConnection.InvokeAsync("CodeUnit", ID);
           
        }
    }
}
