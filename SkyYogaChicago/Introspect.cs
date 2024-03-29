﻿using Android.App;
using Android.OS;
using AppCompatActivity = Android.Support.V7.App.AppCompatActivity;
using Android.Views;
using Android.Content;
using Android.Widget;
using SkyYogaChicago.BusinessLayer.Model;
using SkyYogaChicago.Class;
using System;
using ListView = Android.Widget.ListView;

namespace SkyYogaChicago
{
    [Activity(Label = "Introspect")]
    public class Introspect : AppCompatActivity
    {
        private ListView listView;
        IIntrospect_Videos Info;
        private Introspect_Videos videos = new Introspect_Videos();
        string videoTitle = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            

            SetContentView(SkyYogaChicago.Resource.Layout.Introspect);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(SkyYogaChicago.Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            
               if (Intent.Extras != null)
               {
                   videoTitle = Intent.Extras.GetString("Title");

               }

               if (!string.IsNullOrEmpty(videoTitle))
               {
                   Info = GetResult(videoTitle);
           

            #region Header
            /* TextView txtHeader = new TextView(this);
             txtHeader.Typeface = Android.Graphics.Typeface.DefaultBold;
             txtHeader.TextAlignment= TextAlignment.Center;
             txtHeader.Text = "அகத்தாய்வு முதல்நிலை";*/
            #endregion

                 int videoName = SkyYogaChicago.Resource.Id.text_view_name;
                 int authorName = SkyYogaChicago.Resource.Id.text_view_author;
                 int imageFlag = SkyYogaChicago.Resource.Id.imageViewFlag;
                 int layout = SkyYogaChicago.Resource.Layout.Introspect1_main;
             
                 ImageAdapter imageAdapter = new ImageAdapter(this, Info.VideoName, Info.Author, Info.Resource, videoName, authorName, imageFlag, layout);

                 SetContentView(SkyYogaChicago.Resource.Layout.Introspect);
                 listView = FindViewById<ListView>(SkyYogaChicago.Resource.Id.mainlistView);
                 //listView.AddHeaderView(txtHeader);
                 listView.Adapter = imageAdapter;

                 listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs e)
                 {
                     var id = Info.VideoName[e.Position];
                   //  Toast.MakeText(this, id + " Clicked", ToastLength.Short).Show();
                     Intent intent = new Intent(this, typeof(YouTubePlayer));
                     intent.SetData(Android.Net.Uri.Parse(Info.Url[e.Position]));
                     Bundle bundle = new Bundle();
                     bundle.PutString("Title", Info.VideoName[e.Position]);
                     bundle.PutString("Presenter", Info.Author[e.Position]);
                     intent.PutExtras(bundle);
                     StartActivity(intent);
                 };
             } 
            var backButton = FindViewById<Android.Widget.Button>(Resource.Id.backButton);

            backButton.Click += (object sender, EventArgs e)=>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
                
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }
        private IIntrospect_Videos GetResult(string title)
        {

            switch (videoTitle)
            {
                case "Introspect1_Tamil":
                    Info = videos.GetIntrospect1_Tamil_Info();
                    return Info;
                case "Introspect1_English":
                    Info = videos.GetIntrospect1_English_Info();
                    return Info;
                case "Introspect2_Tamil":
                    Info = videos.GetIntrospect2_Tamil_Info();
                    return Info;
                case "Introspect2_English":
                    Info = videos.GetIntrospect2_English_Info();
                    return Info;
                case "Introspect3_Tamil":
                    Info = videos.GetIntrospect3_Tamil_Info();
                    return Info;
                case "Introspect3_English":
                    Info = videos.GetIntrospect3_English_Info();
                    return Info;
                case "MakolaMadhivirundu":
                    Info = videos.MakolamaiVilandaMadhiVirunduSpeech();
                    return Info;
                case "Songs":
                    Info = videos.VedhathriyamSongs();
                    return Info;
                case "GnanaKalanjiyam_Morning":
                    Info = videos.GnanaKalanjiyam_Speech_Morning();
                    return Info;
                case "GnanaKalanjiyam_Evening":
                    Info = videos.GnanaKalanjiyam_Speech_Evening();
                    return Info;

                case "Maharishi_Sppech":
                    Info = videos.VedhathriMaharishiSpeech_Videos();
                    return Info;

            }
            return null;
        }
    }
}