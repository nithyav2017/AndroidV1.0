using SkyYogaChicago.Forms.Services;
using SkyYogaChicago.Forms.Views;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;

namespace SkyYogaChicago.Forms
{
    public partial class App : Application
    {

        public App(Uri uri)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new YoutubePlayer(uri));

           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
