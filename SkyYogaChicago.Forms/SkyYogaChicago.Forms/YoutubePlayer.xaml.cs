using AngleSharp.Io;
using SkyYogaChicago.Forms.Services;
using System;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using Container = YoutubeExplode.Videos.Streams.Container;
 

namespace SkyYogaChicago.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YoutubePlayer : ContentPage
    {
        VideoClient __videoCLient;
        public YoutubePlayer()
        {

        }
        public YoutubePlayer(Uri uri)
        {
            InitializeComponent();
           // __videoCLient = new VideoClient(uri);
            GetVideoStreams(uri);
        }

        
        private async void GetVideoStreams(Uri uri)
        {
            var youtube = new YoutubeClient();
            var videoId = GetVideoID(uri);
            


            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);//"https://www.youtube.com/watch?v=JHXUqePEkLM");//("https://www.youtube.com/watch?v=KZJUo7D6yNs");

            // var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            //  var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();


            var streamInfo = streamManifest.GetMuxedStreams()
                                            .Where(s => s.Container == Container.Mp4)
                                            .GetWithHighestBitrate();

            var video = await youtube.Videos.GetAsync(videoId);

          
            if (streamInfo != null)
            {
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);   
                MyMediaElement.Source = streamInfo.Url;

                Label labelTitle = (Label)FindByName("VideoTitle");
                labelTitle.Text =   !string.IsNullOrEmpty(video.Title) ?  video.Title :  String.Empty ;         
                labelTitle.IsVisible = true;

                Button button = (Button)FindByName("CloseButton");
                button.IsVisible = true;
            }
        }
        private string GetVideoID(Uri uri)
        {
            var query = HttpUtility.ParseQueryString(uri.Query);

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
        void MediaElement_MediaOpened(System.Object sender, System.EventArgs e)
        {
            MyActivityIndicator.IsVisible = false;
        }

        async void CloseButton_Clicked(System.Object sender, System.EventArgs e)
        {
            MyMediaElement.Stop();
            
            await Navigation.PopAsync();
        }

        
    }
}