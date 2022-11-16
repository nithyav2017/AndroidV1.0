using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace SkyYogaChicago.Forms.Services
{
    internal class Video :IVideo
    {
        public YoutubeExplode.Videos.VideoId Id { get; }

        public string Url { get; }

        public string Title { get; }

        public Author Author { get; }

        public TimeSpan? Duration { get; }

        public DateTimeOffset UploadDate { get; }

        public string Description { get; }

        public string StreamInfoUrl { get; }

        /// <summary>
        /// Initializes an instance of <see cref="Video" />.
        /// </summary>
        public Video(
            VideoId id,
            string title,
            Author author,
            DateTimeOffset uploadDate,
            string description,
            TimeSpan? duration,
            string streamInfoUrl)

        {
            Id = id;
            Title = title;
            Author = author;
            UploadDate = uploadDate;
            Description = description;
            Duration = duration;
            StreamInfoUrl = streamInfoUrl;
        }

        [ExcludeFromCodeCoverage]
        public override string ToString() => $"Video({Title})";

    }
}
