using System;
using System.Collections.Generic;
using System.ComponentModel;
using WSPQ.Models;
using WSPQ.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSPQ.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}