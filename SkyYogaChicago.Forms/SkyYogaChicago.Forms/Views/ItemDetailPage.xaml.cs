using SkyYogaChicago.Forms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SkyYogaChicago.Forms.Views
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