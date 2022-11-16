using System;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace SkyYogaChicago.Forms.Services
{
    internal interface IVideo
    {
        ///<summary>
        ///Video Id
        /// </summary>
        /// 
        VideoId Id { get; }

        ///<summary>
        ///Video Url
        /// </summary>
        /// 
        string Url { get; }

        ///<summary>
        ///Video  Title
        ///</summary>
        ///
        string Title { get; }

        /// <summary>
        /// Video author.
        /// </summary>
        Author Author { get; }

        /// <summary>
        /// Video duration.
        /// </summary>
        /// <remarks>
        /// May be null if the video is a currently ongoing live stream.
        /// </remarks>
        TimeSpan? Duration { get; }

        DateTimeOffset UploadDate { get; }

        /// <summary>
        /// Video description.
        /// </summary>
        string Description { get; }




        /// <summary>
        /// Initializes an instance of <see cref="Video" />.
        /// </summary>
    }
}
