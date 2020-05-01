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

        
        public RegistrationViewModel() 
        {
            IsNotIdentical = false;
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
                await App.Current.MainPage.DisplayAlert("Notification", "Success", "Ok");
            }
            else
            {
                IsNotIdentical = true;
            }



        });
    }
}
