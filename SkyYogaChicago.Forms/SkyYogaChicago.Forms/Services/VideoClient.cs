using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YoutubeExplode.Common;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace SkyYogaChicago.Forms.Services
{
    internal class VideoClient
    {
        ///<summary>
        ///Operations realted to media streams of Youtube Videos
        ///</summary>
        ///
        public IStreamInfo streamInfo { get; set; }

        /// <summary>
        /// uri for the Youtube video
        /// </summary>

        private Uri __uri;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        public VideoClient(Uri uri)
        {
            __uri = uri;

        }

        public async ValueTask<Video> GetVideoStream()
        {
            var youtube = new YoutubeClient();
            var videoId = GetVideoID(__uri);

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);//(__uri.AbsoluteUri);

            // var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            //  var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();


            var streamInfo = streamManifest.GetMuxedStreams()
                                            .Where(s => s.Container == Container.Mp4)
                                            .GetWithHighestBitrate();
            var video = await youtube.Videos.GetAsync(videoId);

            var title = video.Title;
            Author author = video.Author;
            var duration = video.Duration;
            var uploadDate = video.UploadDate;
            var description = video.Description;

            return new Video(videoId, title, author, uploadDate, description, duration, streamInfo.Url);

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

    }
}
