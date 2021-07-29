using System.ComponentModel;
using Xamarin.Forms;
using Notes.ViewModels;

namespace Notes.Views
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
