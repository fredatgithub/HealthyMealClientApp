﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthyMeal.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShoppingListItem : ContentView
	{
        public static readonly BindableProperty NameProperty = BindableProperty.Create(
           nameof(Name),
           typeof(string),
           typeof(ShoppingListItem),
           string.Empty);
        public static readonly BindableProperty AmountProperty = BindableProperty.Create(
            nameof(Amount),
            typeof(string),
            typeof(ShoppingListItem),
            string.Empty);
        public static readonly BindableProperty UnitsNameProperty = BindableProperty.Create(
            nameof(UnitsName),
            typeof(string),
            typeof(ShoppingListItem),
            string.Empty);
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(
            nameof(IsChecked),
            typeof(bool),
            typeof(ShoppingListItem),
            false);
        public static readonly BindableProperty TriggerValueProperty = BindableProperty.Create(
            nameof(TriggerValue),
            typeof(bool),
            typeof(ShoppingListItem),
            false);
        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(
            nameof(TapCommand),
            typeof(IRelayCommand),
            typeof(ShoppingListItem),
            null);
        public static readonly BindableProperty TapCommandParameterProperty = BindableProperty.Create(
            nameof(TapCommandParameter),
            typeof(object),
            typeof(ShoppingListItem),
            null);
        public static readonly BindableProperty CheckBoxCommandProperty = BindableProperty.Create(
            nameof(CheckBoxCommand),
            typeof(IRelayCommand),
            typeof(ShoppingListItem),
            null);
        public static readonly BindableProperty CheckBoxCommandParameterProperty = BindableProperty.Create(
            nameof(CheckBoxCommandParameter),
            typeof(object),
            typeof(ShoppingListItem),
            null);
        public static readonly BindableProperty ButtonCommandProperty = BindableProperty.Create(
            nameof(ButtonCommand),
            typeof(IRelayCommand),
            typeof(ShoppingListItem),
            null);
        public static readonly BindableProperty ButtonCommandParameterProperty = BindableProperty.Create(
            nameof(ButtonCommandParameter),
            typeof(object),
            typeof(ShoppingListItem),
            null);

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        public string Amount
        {
            get => (string)GetValue(AmountProperty);
            set => SetValue(AmountProperty, value);
        }
        public string UnitsName
        {
            get => (string)GetValue(UnitsNameProperty);
            set => SetValue(UnitsNameProperty, value);
        }
        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }
        public bool TriggerValue
        {
            get => (bool)GetValue(TriggerValueProperty);
            set => SetValue(TriggerValueProperty, value);
        }
        public IRelayCommand TapCommand
        {
            get
            {
                return (IRelayCommand)GetValue(TapCommandProperty);
            }
            set => SetValue(TapCommandProperty, value);
        }
        public object TapCommandParameter
        {
            get => (object)GetValue(TapCommandParameterProperty);
            set => SetValue(TapCommandParameterProperty, value);
        }
        public IRelayCommand CheckBoxCommand
        {
            get
            {
                return (IRelayCommand)GetValue(CheckBoxCommandProperty);
            }
            set => SetValue(CheckBoxCommandProperty, value);
        }
        public object CheckBoxCommandParameter
        {
            get => (object)GetValue(CheckBoxCommandParameterProperty);
            set => SetValue(CheckBoxCommandParameterProperty, value);
        }
        public IRelayCommand ButtonCommand
        {
            get
            {
                return (IRelayCommand)GetValue(ButtonCommandProperty);
            }
            set => SetValue(ButtonCommandProperty, value);
        }
        public object ButtonCommandParameter
        {
            get => (object)GetValue(ButtonCommandParameterProperty);
            set => SetValue(ButtonCommandParameterProperty, value);
        }

        public ShoppingListItem ()
		{
			InitializeComponent ();
		}
	}
}