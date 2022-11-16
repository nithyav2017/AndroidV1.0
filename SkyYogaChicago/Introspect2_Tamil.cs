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
    [Activity(Label = "Introspect2_Tamil")]
    public class Introspect2_Tamil : AppCompatActivity
    {
        private Introspect_Videos videos = new Introspect_Videos();
        ListView listview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}