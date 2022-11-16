using SkyYogaChicago.Forms.ViewModels;
using SkyYogaChicago.Forms.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SkyYogaChicago.Forms
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
