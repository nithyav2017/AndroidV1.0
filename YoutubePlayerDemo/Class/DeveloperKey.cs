using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoutubePlayerDemo.Class
{
    // Static container class for holding a reference to your YouTube Developer Key.
    internal static class DeveloperKey
    {
        /// <summary>
		/// Please replace this with a valid API key which is enabled for the
		/// YouTube Data API v3 service. Go to the Google Developers Console
		/// to register a new developer key: 
		///     https://console.developers.google.com/
		/// </summary>
		/// https://www.thewissen.io/embedding-youtube-feed-xamarin-forms/
		/// 
		public const string Key = "AIzaSyCf8XdrfUk1xqNqF3s8iNKvE_Tlu9JsKkg";

        static DeveloperKey()
        {
            if (Key != "AIzaSyCf8XdrfUk1xqNqF3s8iNKvE_Tlu9JsKkg")
            {
                throw new Exception("You API key has not been set.");
            }
        }
    }
}