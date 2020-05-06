using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XaBarcodeScannerProject.Views;
using Xamarin.Forms;

namespace XaBarcodeScannerProject.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        HubConnection hubConnection;
        

        public RegistrationViewModel() 
        {

            hubConnection = new HubConnectionBuilder()
            .WithUrl("https://localhost:5000/Controllers")
            .Build();

            //Connect to the backend
            //Connect()

            IsNotIdentical = false;




            hubConnection.On<string>("CreateCustomerCU", (reply) =>
            {
                //Should be fired when the event is correct
                //App.Current.MainPage.DisplayAlert("Notification", "Success", "Ok");
            });


        }


        private bool isNotIdentical;

        public bool IsNotIdentical
        {
            get { return isNotIdentical; }
            set 
            { 
                isNotIdentical=value;
                OnPropertyChanged();
            }
        }


        private string firstNameRVM;
        

        public string FirstNameRVM
        {
            get { return firstNameRVM; }
            set 
            {
                firstNameRVM = value;
                OnPropertyChanged();
            }
        }

        private string emailRVM;

        public string EmailRVM
        {
            get { return emailRVM; }
            set { emailRVM = value; OnPropertyChanged(); }
        }

        private string latNameRVM;

        public string LastNameRVM
        {
            get { return latNameRVM; }
            set { latNameRVM = value; OnPropertyChanged(); }
        }
        private string passwordRVM;

        public string PasswordRVM
        {
            get { return passwordRVM; }
            set { passwordRVM = value; OnPropertyChanged(); }
        }

        private string confirmPasswordRVM;

        public string ConfirmPasswordRVM
        {
            get { return confirmPasswordRVM; }
            set { confirmPasswordRVM = value; OnPropertyChanged(); }
        }

        public ICommand GoBack => new Command(async () => {
            Console.WriteLine("VIRKER DET");
            // navigate back to login page            
             App.Current.MainPage = new LoginView();
           
        });

        public ICommand SignUp => new Command(async () => {

            if (passwordRVM == confirmPasswordRVM)
            {
                Console.WriteLine("det virker");      
                IsNotIdentical = false;

                //Call the backend if the condition is true
                //await hubConnection.InvokeAsync("CreateCustomerCU", FirstNameRVM, LastNameRVM, EmailRVM, PasswordRVM);
                
                //Should probably be called from an event 
                await App.Current.MainPage.DisplayAlert("Notification", "Success", "Ok");
    
            }
            else
            {
                IsNotIdentical = true;
            }

        });

        async Task Connect()
        {
            try
            {
                await hubConnection.StartAsync();
                Console.WriteLine("Is connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("ConnectMethod Error: " + e.Message);

            }
        }


    }
}
