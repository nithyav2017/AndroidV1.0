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
         

        /// <summary>
        /// returns Introspect Tamil Lessons and Details
        /// Create an instance for Instrospect_Videos and assign interface members to it.
        /// </summary>
        /// <returns></returns>
        public IIntrospect_Videos GetIntrospect1_Tamil_Info()
        {
           _name = new string[] { "Who Am I?  ",
                                  "சினம் தவிர்த்தல்  ",
                                  "ஆசை சீரமைத்தல்  " ,
                                  "கவலை ஒழித்தல்  ",
                                  "பஞ்சேந்திரிய தவம்"
                                    };
            _author= new string[]  {     "By: Sr. Prof. பாலச்சந்திரன் ஐயா",
                                           "By: அருள்நிதி ராஜலட்சுமி அம்மா",
                                           "By: அருள்நிதி சாந்தி ஜி அம்மா",
                                           "By: அருள்நிதி ராஜேஸ்வரி அம்மா",
                                           "By: அருள்நிதி மீனாக்ஷி அம்மா"
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

        public IIntrospect_Videos  GetIntrospect1_English_Info()
        {
            _name = new string[] { "Moralization of Desires " ,
                                         @"PanchaBootha Navagraha Mediation\Greatness of Women  ",
                                         "Neutralization of Anger  ",
                                         "Purpose of life and Philosophy of life  "

                                    };
            _author = new string[]  { "By: Arulnithi Sankari Amma",
                                           "By: Arulnithi Karthikeyan Nagendran",
                                           "By: Arulnithi Gulshan Singh",
                                           "By:  ",

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=bJWGJmMvEDQ",
                                       "https://www.youtube.com/watch?v=ThosRsx5OVQ",
                                       "https://www.youtube.com/watch?v=E4wTiub1p10",
                                       "https://www.youtube.com/watch?v=p93PECXcMNw"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;

        }
         
        public IIntrospect_Videos  GetIntrospect2_Tamil_Info()
        {
            _name = new string[] { "ஒழுக்க பண்பாடு " ,
                                         "துரியாதீத தவம் ",
                                         "அறுகுண சீரமைப்பு  ",
                                         "தீப பயிற்சி  ",
                                         "மௌனத்தின் மேன்மை"

                                    };
            _author = new string[]  { "By: ",
                                           "By: அருள்நிதி அருள்மதி அம்மா",
                                           "By: அருள்நிதி சாந்தி ஜி அம்மா",
                                           "By: அருள்நிதி வனஜா அம்மா ",
                                           "By: அருள்நிதி சாந்தி ஜி அம்மா"

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=OitEo8MwkFQ",
                                       "https://www.youtube.com/watch?v=1fJ4YOT6ZgY",
                                       "https://www.youtube.com/watch?v=ND1ylH3-zrQ",
                                       "https://www.youtube.com/watch?v=rsJZ-IQww-s",
                                       "https://www.youtube.com/watch?v=fmqmTIrzB0Q"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos GetIntrospect2_English_Info()
        {
            _name = new string[] { "Sin Imprints & ways to remove them " ,
                                         "Why human differ ?&Nithyananda Mediatation  ",
                                         "Maneuver of temperaments and Consciousness is God  ",
                                         "Introspection English - Reformed Culture and Karma yoga  ",
                                         " Greatness of Silence - Family peace"

                                    };
            _author = new string[]  { "By: ",
                                           "By: Arulnidhi Venkatesh Kumar Ayya",
                                           "By: Arulnidhi Prabhu Ayya",
                                           "By:  ",
                                           "By: "

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=q_9iBIj80zw",
                                       "https://www.youtube.com/watch?v=L8-iVHH2Pkk",
                                       "https://www.youtube.com/watch?v=wDDX-d5TPSI",
                                       "https://www.youtube.com/watch?v=pB_1iiZ6Opw",
                                       "https://www.youtube.com/watch?v=vfd6v9cFfxs"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos GetIntrospect3_Tamil_Info()
        {
            _name = new string[] { "அறிவே தெய்வம் " ,
                                         "கர்மயோகம் ",
                                         "ஒன்பது மைய தவம்  ",
                                         "கண்ணாடி பயிற்சி  ",
                                         "மனிதருள் வேறுபாடு ஏன் ?"

                                    };
            _author = new string[]  { "By: அருள்நிதி Dr.மீனாக்ஷி அம்மா",
                                           "By: அருள்நிதி கோதை கோவிந்தராஜன் அம்மா",
                                           "By: அருள்நிதி சாந்தி ஜி அம்மா",
                                           "By: அருள்நிதி முத்துச்சுடர்கொடி அம்மா ",
                                           "By: அருள்நிதி சாந்தி ஜி அம்மா"

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=IdCrGAPjcFU",
                                       "https://www.youtube.com/watch?v=-bG_1lLVWkM",
                                       "https://www.youtube.com/watch?v=llLNeO1TQ4E",
                                       "https://www.youtube.com/watch?v=y7VZWZX8If0",
                                       "https://www.youtube.com/watch?v=YIZNwwWdZpY"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos GetIntrospect3_English_Info()
        {
            throw new NotImplementedException();
        }

        public IIntrospect_Videos GnanaKalanjiyam_Speech_Morning()
        {
            _name = new string[] { "ஞானகளஞ்சியம் கவி - 1532 " ,
                                         "ஞானகளஞ்சியம் கவி - 1309 ",
                                         "ஞானகளஞ்சியம் கவி - 1298  ",
                                         "ஞானகளஞ்சியம் கவி - 1501  ",
                                         "ஞானகளஞ்சியம் கவி - 1319"

                                    };
            _author = new string[]  { "By: அருள்நிதி கோதைகோவிந்தராஜன் அம்மா ",
                                           "By: அருள்நிதி சஞ்சீவ் சிதம்பரம் அம்மா",
                                           "By: அருள்நிதி சாந்தி அம்மா ",
                                           "By: அருள்நிதி ரூபாவதி அம்மா ",
                                           "By: அருள்நிதி வித்யா அம்மா"

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=uNPSeeLPBHQ",
                                       "https://www.youtube.com/watch?v=jllvRzHLwcc",
                                       "https://www.youtube.com/watch?v=AW0J-v3xulI",
                                       "https://www.youtube.com/watch?v=FfoM_nUsfuw",
                                       "https://www.youtube.com/watch?v=6qHIA9dA_P4"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos GnanaKalanjiyam_Speech_Evening()
        {
            _name = new string[] { "ஞானகளஞ்சியம் கவி - 650 " ,
                                         "ஞானகளஞ்சியம் கவி - 1540 ",
                                         "ஞானகளஞ்சியம் கவி - 1725 ",
                                         "ஞானகளஞ்சியம் கவி - 502  ",
                                         "ஞானகளஞ்சியம் கவி - 650"

                                    };
            _author = new string[]  { "By: அருள்நிதி முகில் அம்மா ",
                                           "By: அருள்நிதி அனிதா அம்மா",
                                           "By: அருள்நிதி Dr.மீனாக்ஷி அம்மா ",
                                           "By: அருள்நிதி ஆனந்தி அம்மா ",
                                           "By: அருள்நிதி முகில் அம்மா"

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=tVMYj_Il0mQ",
                                       "https://www.youtube.com/watch?v=O7Y0BVZE9DI",
                                       "https://www.youtube.com/watch?v=ZKwdhKXa_XQ",
                                       "https://www.youtube.com/watch?v=bfyS6cfSFIA",
                                       "https://www.youtube.com/watch?v=tVMYj_Il0mQ"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos VedhathriMaharishiSpeech_Videos()
        {
            throw new NotImplementedException();
        }

        public IIntrospect_Videos VedhathriyamSongs()
        {
            _name = new string[] { "எப்பொருளை எச்செயலை " ,
                                         "அண்டம் அதில் உருவெடுத்து ",
                                         "இறைவெளியே தன்னிருக்க   ",
                                         "பூரண பொருளே  ",
                                         "தன்முனைப்பு அறுகுணம்"

                                    };
            _author = new string[] { };

            _url = new string[]   { "https://www.youtube.com/watch?v=LxnjDB-ugXs",
                                       "https://www.youtube.com/watch?v=Iv7wpfQ9H0c",
                                       "https://www.youtube.com/watch?v=cYunqcKVXUU",
                                       "https://www.youtube.com/watch?v=1dM6-SkQcVU",
                                       "https://www.youtube.com/watch?v=xmB6mLfYxW4"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }

        public IIntrospect_Videos MakolamaiVilandaMadhiVirunduSpeech()
        {
            _name = new string[] { "தோற்றமும் அறிவும் " ,
                                         "தெளிந்த முடிவு ",
                                         "உயிர் நிலையறிய  ",
                                         "இருளும் ஈசனும் & அறிவின் நிலை  ",
                                         "தியாகியும் ஞானியும்"

                                    };
            _author = new string[]  { "By: அருள்நிதி ஆனந்தி அம்மா ",
                                           "By: அருள்நிதி ஆனந்தி அம்மா ",
                                           "By: அருள்நிதி ஆனந்தி அம்மா ",
                                           "By: அருள்நிதி ஆனந்தி அம்மா ",
                                           "By: புலவர் அருள்நிதி ராசாராம் சுடலைமுத்து ஐயா"

            };
            _url = new string[]   { "https://www.youtube.com/watch?v=ITveWOYnsdY",
                                       "https://www.youtube.com/watch?v=c74zq-WTZEw",
                                       "https://www.youtube.com/watch?v=-BIZ-9jfZ68",
                                       "https://www.youtube.com/watch?v=57zlC0uQvvQ",
                                       "https://www.youtube.com/watch?v=-UtiGsoXLtc"

            };

            _resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            Introspect_Videos __introspectVideos = new Introspect_Videos();
            __introspectVideos.VideoName = _name;
            __introspectVideos.Author = _author;
            __introspectVideos.Url = _url;
            __introspectVideos.Resource = _resource;
            return __introspectVideos;
        }
        #endregion
    }

}