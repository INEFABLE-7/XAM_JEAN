using System.ComponentModel;
using XAM_MOVIL7.ViewModels;
using Xamarin.Forms;

namespace XAM_MOVIL7.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}