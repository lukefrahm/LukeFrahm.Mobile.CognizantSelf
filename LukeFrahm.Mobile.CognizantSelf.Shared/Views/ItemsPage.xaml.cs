using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LukeFrahm.Mobile.CognizantSelf.Shared.Models;
using LukeFrahm.Mobile.CognizantSelf.Shared.Views;
using LukeFrahm.Mobile.CognizantSelf.Shared.ViewModels;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Views
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