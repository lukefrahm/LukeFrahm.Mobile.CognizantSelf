using System.ComponentModel;
using Xamarin.Forms;
using LukeFrahm.Mobile.CognizantSelf.Shared.ViewModels;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Views
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