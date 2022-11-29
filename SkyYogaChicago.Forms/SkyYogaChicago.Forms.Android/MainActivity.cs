using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace SkyYogaChicago.Forms.Droid
{
    [Activity(Label = "SkyYogaChicago.Forms", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        string presenter = string.Empty;
        string youtubeUri = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            
            if (Intent.Data != null && Intent.Extras != null)
            {
                var uri = Intent.Data;               
              //  presenter = !string.IsNullOrEmpty(Intent.Extras.GetString("Presenter")) ? Intent.Extras.GetString("Presenter").Trim():string.Empty ;
                youtubeUri = !string.IsNullOrEmpty(uri.ToString()) ? uri.ToString().Trim() : string.Empty;
                Uri systemUri = new Uri(youtubeUri, UriKind.RelativeOrAbsolute);
                LoadApplication(new SkyYogaChicago.Forms.App(systemUri));
            }
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}