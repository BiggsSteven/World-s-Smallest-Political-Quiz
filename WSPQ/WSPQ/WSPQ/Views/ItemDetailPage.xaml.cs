using System.ComponentModel;
using WSPQ.ViewModels;
using Xamarin.Forms;

namespace WSPQ.Views
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