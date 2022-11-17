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

namespace SkyYogaChicago.BusinessLayer.Model
{
    internal interface IIntrospect_Videos
    { 
          string[] VideoName { get; set; }
          string[] Author { get; set; }
          string[] Url { get; set; }
          int[] Resource { get; set;     }

          IIntrospect_Videos GetIntrospect1_Tamil_Info(); 
          IIntrospect_Videos GetIntrospect1_English_Info();
          IIntrospect_Videos GetIntrospect2_Tamil_Info();
          IIntrospect_Videos GetIntrospect2_English_Info();
          IIntrospect_Videos GetIntrospect3_Tamil_Info();
          IIntrospect_Videos GetIntrospect3_English_Info();
          IIntrospect_Videos GnanaKalanjiyam_Speech_Morning();
          IIntrospect_Videos GnanaKalanjiyam_Speech_Evening();

          IIntrospect_Videos MakolamaiVilandaMadhiVirunduSpeech();
          IIntrospect_Videos VedhathriMaharishiSpeech_Videos();
          IIntrospect_Videos VedhathriyamSongs();

    }
}