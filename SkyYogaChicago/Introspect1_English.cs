using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SkyYogaChicago.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyYogaChicago
{
    [Activity(Label = "Introspect1_English")]
    public class Introspect1_English : AppCompatActivity
    {
        private Introspect_Videos videos = new Introspect_Videos();
        ListView listview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
         
            videos.name = new string[] { "Moralization of Desires " ,
                                         @"PanchaBootha Navagraha Mediation\Greatness of Women  ",
                                         "Neutralization of Anger  ",
                                         "Purpose of life and Philosophy of life  " 
                                         
                                    };

            videos.author = new string[] { "By: Arulnithi Sankari Amma",
                                           "By: Arulnithi Karthikeyan Nagendran",
                                           "By: Arulnithi Gulshan Singh",
                                           "By:  ",

            };

         
            videos.resource = new int[] { SkyYogaChicago.Resource.Drawable.playbutton };

            videos.url = new string[] { "https://www.youtube.com/watch?v=bJWGJmMvEDQ",
                                       "https://www.youtube.com/watch?v=ThosRsx5OVQ",
                                       "https://www.youtube.com/watch?v=E4wTiub1p10",
                                       "https://www.youtube.com/watch?v=p93PECXcMNw"

            };

           

            int videoName = SkyYogaChicago.Resource.Id.text_view_name;
            int authorName = SkyYogaChicago.Resource.Id.text_view_author;
            int imageFlag = SkyYogaChicago.Resource.Id.imageViewFlag;
            int layout = SkyYogaChicago.Resource.Layout.Introspect1_main_English;
            ImageAdapter imageAdapter = new ImageAdapter(this, videos.name, videos.author, videos.resource, videoName, authorName, imageFlag, layout);

            SetContentView(SkyYogaChicago.Resource.Layout.Introspect1_English);
            listview = FindViewById<ListView>(SkyYogaChicago.Resource.Id.mainlistView);
            //listView.AddHeaderView(txtHeader);
            listview.Adapter = imageAdapter;

            listview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs e)
            {
                var id = videos.name[e.Position];
                Toast.MakeText(this, id + " Clicked", ToastLength.Short).Show();
                Intent intent = new Intent(this, typeof(SkyYogaChicago.Forms.Droid.MainActivity));
                intent.SetData(Android.Net.Uri.Parse(videos.url[e.Position]));
                StartActivity(intent);
            };
        }
    }
}