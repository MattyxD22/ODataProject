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
            //Messages = new ObservableCollection<string>();

            Console.WriteLine("virker det???");

            hubConnection = new HubConnectionBuilder()
            .WithUrl("https://projectnavision20200502131207.azurewebsites.net/HubClass")
            .Build();

            Connect();
            TestMethod("Mathias");

            hubConnection.On<string>("SendMessage", (inputString) =>
            {
                Console.WriteLine("Message has been sent: " + inputString);
                Result = Messages;

                //Messages.Add(new Message() { Username = user, Text = $"{user} has joined the chat", IsSystemMessage = true, Date = DateTime.Now });
            });

            hubConnection.On<string>("JoinChat", (user) =>
            {
                Console.WriteLine("joined");
                TestMethod("Mathias");
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

        public Command SendMessageCommand => new Command(async () =>
        {
            await TestMethod(Messages);
            Console.WriteLine(Messages);
            Console.WriteLine(Result);

        });

        async Task Connect()
        {
            try
            {
                Console.WriteLine("Is connected");
                await hubConnection.StartAsync();
                await hubConnection.InvokeAsync("JoinChat", "mig");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        async Task TestMethod(string inputString)
        {
            
            await hubConnection.InvokeAsync("CodeUnit", inputString);
        }
    }
}
