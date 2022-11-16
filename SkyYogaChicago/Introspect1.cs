using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using SkyYogaChicago.BusinessLayer.Model;
using SkyYogaChicago.Class;
 using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using static Android.Icu.Text.IDNA;
using ActionBar = Android.Support.V7.App.ActionBar;
using ListView = Android.Widget.ListView;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace SkyYogaChicago
{
    [Activity(Label = "Introspect1")]
    public class Introspect1 : AppCompatActivity 
    {
       
        private ListView listView;
        IIntrospect_Videos Info;
        private Introspect_Videos videos = new Introspect_Videos();
        string videoTitle = string.Empty;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

           
            if(Intent.Extras != null)
            {

                videoTitle = Intent.Extras.GetString("Title");

            }

            if(!string.IsNullOrEmpty(videoTitle))
            {
                switch(videoTitle)
                {
                    case "Introspect1_Tamil":
                        var s= videos.GetIntrospect1_Tamil_Info();
                      //  var s = Info.VideoName;
                        return;

                }
            }

        
            
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
            // ImageAdapter imageAdapter = new ImageAdapter(this, videos.name, videos.author, videos.resource,videoName, authorName,imageFlag,layout);
            ImageAdapter imageAdapter = new ImageAdapter(this, Info.VideoName, Info.Author, Info.Resource, videoName, authorName, imageFlag, layout);

            SetContentView(SkyYogaChicago.Resource.Layout.Introspect1);
            listView = FindViewById<ListView>(SkyYogaChicago.Resource.Id.mainlistView);
          //listView.AddHeaderView(txtHeader);
            listView.Adapter = imageAdapter;

         listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs e)
         {
             var id = Info.VideoName[e.Position];
             Toast.MakeText(this, id + " Clicked", ToastLength.Short).Show();
             Intent intent = new Intent(this, typeof(SkyYogaChicago.Forms.Droid.MainActivity));
             intent.SetData(Android.Net.Uri.Parse(Info.Url[e.Position]));
             StartActivity(intent);
         };


           

        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home: Finish();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }
         



    }
}