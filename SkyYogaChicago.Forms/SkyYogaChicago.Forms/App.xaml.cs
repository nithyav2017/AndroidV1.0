using SkyYogaChicago.Forms.Services;
using SkyYogaChicago.Forms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkyYogaChicago.Forms
{
    public partial class App : Application
    {

        public App(Uri uri)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new YoutubePlayer(uri); //new AppShell();
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
