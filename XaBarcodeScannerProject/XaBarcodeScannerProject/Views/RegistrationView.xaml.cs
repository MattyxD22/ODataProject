﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XaBarcodeScannerProject.Models;
using XaBarcodeScannerProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XaBarcodeScannerProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationView : ContentPage
    {
        public RegistrationView()
        {
            InitializeComponent();
            BindingContext = new RegistrationViewModel();
        }

        

    }
}