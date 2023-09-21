using System;
using System.Collections.Generic;
using System.ComponentModel;
using XAM_MOVIL7.Models;
using XAM_MOVIL7.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAM_MOVIL7.Views
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