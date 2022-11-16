using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Security;
using Java.Util;
using SkyYogaChicago.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeExplode.Common;
using static Java.Util.Jar.Attributes;

namespace SkyYogaChicago.Class
{

    /// <summary>
    /// SOLID- Single Responsibility Principle
    /// </summary>
    internal class Introspect_Videos : IIntrospect_Videos
    {
        
        private string[] _name;
        private string[] _author;
        private int[] _resource;
        private string[] _url;

        #region Properties Implementation
        public string[] VideoName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string[] Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int[] Resource
        {
            get { return _resource; }
            set { _resource = value; }
        }

        public string[] Url
        {
            get { return _url; }
            set { _url = value; }
        }
        #endregion

        #region Method Implementation
        public IIntrospect_Videos[] GetIntrospect1_English_Info( IIntrospect_Videos videos)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// returns Introspect Tamil Lessons and Details
        /// Create an instance for Instrospect_Videos and assign interface members to it.
        /// </summary>
        /// <returns></returns>
        public IIntrospect_Videos GetIntrospect1_Tamil_Info()
        {
           _name = new string[] { "எண்ணம் ஆராய்தல்  " ,
                                         "Who Am I?  ",
                                         "சினம் தவிர்த்தல்  ",
                                         "ஆசை சீரமைத்தல்  " ,
                                         "கவலை ஒழித்தல்  "
                                    };
            _author= new string[]  { "By: Arulnidhi Nagarani Purushothaman",
                                           "",
                                           "By: Sr. Prof. Balachandran",
                                           "By: Arulnidhi Rajalakshmi",
                                           "By: Arulnidhi Shanthi G",
                                           "By: Arulnidhi Rejeswari"
            };
            _url = new string[]  {"https://www.youtube.com/watch?v=PzHxP8tMjys",
                                       "https://www.youtube.com/watch?v=4Lpy9dN7ag0",
                                       "https://www.youtube.com/watch?v=pm7TFs26BT0",
                                       "https://www.youtube.com/watch?v=61Qr9OFJHs4",
                                       "https://www.youtube.com/watch?v=1Smn1gTT6-M"
            };

            _resource= new int[] { SkyYogaChicago.Resource.Drawable.playbutton };           

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;

        }

        public IIntrospect_Videos[] GetIntrospect2_Tamil_Info()
        {
            throw new NotImplementedException();
        }

        IIntrospect_Videos[] IIntrospect_Videos.GetIntrospect1_English_Info()
        {
            throw new NotImplementedException();
        }

        IIntrospect_Videos[] IIntrospect_Videos.GetIntrospect1_Tamil_Info()
        {
            throw new NotImplementedException();
        }

        IIntrospect_Videos[] IIntrospect_Videos.GetIntrospect2_Tamil_Info()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}