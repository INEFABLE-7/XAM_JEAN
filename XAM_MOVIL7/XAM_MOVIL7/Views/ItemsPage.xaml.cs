using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAM_MOVIL7.Models;
using XAM_MOVIL7.ViewModels;
using XAM_MOVIL7.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAM_MOVIL7.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}