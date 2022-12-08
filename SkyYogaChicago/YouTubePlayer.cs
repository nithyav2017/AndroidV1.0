using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SkyYogaChicago.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTube.Player;

namespace SkyYogaChicago
{
    [Activity(Label = "YouTube Player", ScreenOrientation = Android.Content.PM.ScreenOrientation.Nosensor, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.KeyboardHidden,
        Theme = "@style/AppTheme")]
    public class YouTubePlayer : YouTubeBaseActivity, IYouTubePlayerOnInitializedListener
    {
        public const int RecoveryDialogRequest = 1;

        string presenter = string.Empty;
        string youtubeUri = string.Empty;
        string title = String.Empty;
        string videoId = string.Empty;

       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.YoutubePlayerView);

            if (Intent.Data != null && Intent.Extras != null)
            {
                var uri = Intent.Data;
                presenter = !string.IsNullOrEmpty(Intent.Extras.GetString("Presenter")) ? Intent.Extras.GetString("Presenter").Trim() : string.Empty;
                title = !string.IsNullOrEmpty(Intent.Extras.GetString("Title")) ? Intent.Extras.GetString("Title").Trim() : string.Empty;
                youtubeUri = !string.IsNullOrEmpty(uri.ToString()) ? uri.ToString().Trim() : string.Empty;
                Uri systemUri = new Uri(youtubeUri, UriKind.RelativeOrAbsolute);
                videoId = GetVideoID(systemUri);
                var youTubeView = FindViewById<YouTubePlayerView>(Resource.Id.youtube_view);
                youTubeView.Initialize(DeveloperKey.Key, this);
 
            }

            var closeButton = FindViewById<Android.Widget.Button>(Resource.Id.closeButton);

            closeButton.Click += (object sender, EventArgs e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
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
                TextView textViewTitle = FindViewById<TextView>(Resource.Id.txtTitle);
                textViewTitle.Text = "Title: "+ title;
                textViewTitle.Visibility = ViewStates.Visible;

                TextView textViewPresenter = FindViewById<TextView>(Resource.Id.txtpresenter);
                textViewPresenter.Text = presenter;
                textViewPresenter.Visibility = ViewStates.Visible;

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
    }
}