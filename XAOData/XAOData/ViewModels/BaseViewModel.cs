using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XAOData.ViewModels
{
   public class BaseViewModel : Page,INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

       public void OnpropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
