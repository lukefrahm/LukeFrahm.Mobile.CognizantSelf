using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LukeFrahm.Mobile.CognizantSelf.Shared.Models;
using LukeFrahm.Mobile.CognizantSelf.Shared.ViewModels;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Views
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