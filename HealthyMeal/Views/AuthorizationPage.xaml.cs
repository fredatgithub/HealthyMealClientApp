﻿using HealthyMeal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthyMeal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        private static readonly AuthorizationPageViewModel _vm = new();
        public AuthorizationPage()
        {
            InitializeComponent();
            BindingContext = _vm;
        }
    }
}