using System;
using System.Linq;
using System.Text.RegularExpressions;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.ConstraintLayout.Widget;
 using YouTube.Player;
using YoutubePlayerDemo.Class;
 
namespace YoutubePlayerDemo
{
    [Activity(Label = "@string/playerview_demo_name", ScreenOrientation = Android.Content.PM.ScreenOrientation.Nosensor, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize|ConfigChanges.KeyboardHidden,
        Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : YouTubeBaseActivity, IYouTubePlayerOnInitializedListener
    {
        YouTubePlayerView youTubePlayerView;
        public const int RecoveryDialogRequest = 1;
        string videoId = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.player_view_demo);
            Uri uri = new Uri("https://www.youtube.com/watch?v=R1V-eWFVfJM");
            videoId = GetVideoID(uri);
            var youTubeView = FindViewById<YouTubePlayerView>(Resource.Id.youtube_view);
            youTubeView.Initialize(DeveloperKey.Key, this);

            

        }

       
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

       

        public void OnInitializationFailure(IYouTubePlayerProvider provider, YouTubeInitializationResult errorReason)
        {
            if (errorReason.IsUserRecoverableError)
            {
                errorReason.GetErrorDialog(this, RecoveryDialogRequest).Show();
            }
            else
            {
                var errorMessage = string.Format(GetString(Resource.String.error_player), errorReason);
                Toast.MakeText(this, errorMessage, ToastLength.Long).Show();
            }
        } 

        public void OnInitializationSuccess(IYouTubePlayerProvider p0, IYouTubePlayer p1, bool wasRestored)
        {
            if (!wasRestored)
            {
                p1.CueVideo(videoId);
                TextView textView = FindViewById<TextView>(Resource.Id.txtTitle);
                p1.SetManageAudioFocus(true);
                
            }
        }

        private string GetVideoID(Uri uri)
        {
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);

            var videoId = string.Empty;

            if (query.AllKeys.Contains("v"))
            {
                videoId = query["v"];
            }
            else
            {
                videoId = uri.Segments.Last();
            }
            return videoId;

             
        }

        //protected override IYouTubePlayerProvider YouTubePlayerProvider
        //    => FindViewById<YouTubePlayerView>(Resource.Id.youtube_view);
    }
}