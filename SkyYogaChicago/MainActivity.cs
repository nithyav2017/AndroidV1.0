using Android.App;
using Android.OS;
using Android.Runtime;
using AppCompatActivity = Android.Support.V7.App.AppCompatActivity;
using Android.Views;
using Google.Android.Material.Navigation;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Content;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using SearchView = Android.Support.V7.Widget.SearchView;
using Xamarin.Forms;
using Android.Widget;
using SkyYogaChicago.BusinessLayer.Model;
using System.Collections.Generic;
using SkyYogaChicago.BusinessLayer;
using System;

namespace SkyYogaChicago
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary>
        /// 
        /// </summary>
        DrawerLayout drawerLayout;
        NavigationView navigationView;
        ActionBarDrawerToggle actionBarDrawerToggle;
        SearchView searchView;
        Intent intent;
        IExpandableListAdapter menuAdapter;
        ExpandableListView expandableList;
        List<ExpandedMenuModel> listDataHeader;
        Dictionary<ExpandedMenuModel, List<string>> listDataChild;
        public bool ToolbarNavigationListenerIsRegistered;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var toolbar = FindViewById<V7Toolbar>(SkyYogaChicago.Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
             
           
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(SkyYogaChicago.Resource.Drawable.abc_ic_menu_copy_mtrl_am_alpha);

            drawerLayout = FindViewById<DrawerLayout>(SkyYogaChicago.Resource.Id.drawer_layout);
            actionBarDrawerToggle = new ActionBarDrawerToggle(this, drawerLayout, SkyYogaChicago.Resource.String.nav_open, SkyYogaChicago.Resource.String.nav_close);
            drawerLayout.AddDrawerListener(actionBarDrawerToggle);
            actionBarDrawerToggle.SyncState();

            ExpandableListView expandableList = FindViewById<ExpandableListView>(Resource.Id.navigationmenu);
            navigationView = FindViewById<NavigationView>(SkyYogaChicago.Resource.Id.nav_view);
           
            #region obsolete

            navigationView.NavigationItemSelected += (sender, e) =>
            {
                Bundle bundle;
                switch (e.MenuItem.ItemId)
                {

                    case SkyYogaChicago.Resource.Id.Introspection_1T:
                        // Toast.MakeText(this, "Introspection_1 Clicked", ToastLength.Short).Show();
                        Intent intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect1_Tamil");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Introspection_1E:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect1_English");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Introspection_2T:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect2_Tamil");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;
                    case SkyYogaChicago.Resource.Id.Introspection_2E:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect2_English");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;
                    case SkyYogaChicago.Resource.Id.Introspection_3T:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect3_Tamil");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;
                    case SkyYogaChicago.Resource.Id.Introspection_3E:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Introspect3_English");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;
                    case SkyYogaChicago.Resource.Id.MadhiVirundu:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "MakolaMadhivirundu");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Songs:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Songs");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Speech_Morning:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "GnanaKalanjiyam_Morning");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Speech_Evening:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "GnanaKalanjiyam_Evening");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;

                    case SkyYogaChicago.Resource.Id.Speech_Maharishi:
                        intent = new Intent(this, typeof(Introspect));
                        bundle = new Bundle();
                        bundle.PutString("Title", "Maharishi_Sppech");
                        intent.PutExtras(bundle);
                        StartActivity(intent);
                        return;
                }

                e.MenuItem.SetChecked(true);
                drawerLayout.CloseDrawers();
            };
            #endregion

            PrepareListdata();

            menuAdapter = new ExpandableListAdapter(this, listDataHeader, listDataChild, expandableList);
            expandableList.SetAdapter(menuAdapter);

            expandableList.ChildClick += (object sender, ExpandableListView.ChildClickEventArgs e) =>
            {
                Bundle bundle;
                switch (listDataHeader[e.GroupPosition].Id)
                {
                    case 1:
                        if (e.ChildPosition == 0)
                        {
                            Intent intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect1_Tamil");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                        else
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect1_English");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                    case 2:
                        if (e.ChildPosition == 0)
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect2_Tamil");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                        else
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect2_English");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                    case 3:
                        if (e.ChildPosition == 0)
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect3_Tamil");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                        else
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Introspect3_English");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }

                    case 4:
                        if (e.ChildPosition == 0)
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "GnanaKalanjiyam_Morning");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                        else
                        {
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "GnanaKalanjiyam_Evening");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        }
                        
                }


            };

            expandableList.GroupClick += (object sender, ExpandableListView.GroupClickEventArgs e) =>
            {
                Bundle bundle;
                if (menuAdapter.GetChildrenCount(e.GroupPosition) == 0)
                { 
                    switch (listDataHeader[e.GroupPosition].Id)
                    {
                        case 5:
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "MakolaMadhivirundu");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                        case 6:
                            intent = new Intent(this, typeof(Introspect));
                            bundle = new Bundle();
                            bundle.PutString("Title", "Songs");
                            intent.PutExtras(bundle);
                            StartActivity(intent);
                            return;
                    }
                }
                else
                {
                    if (expandableList.IsGroupExpanded(e.GroupPosition))
                    {
                        expandableList.CollapseGroup(e.GroupPosition);
                    }
                    else
                    {
                        expandableList.ExpandGroup(e.GroupPosition);
                    }
                }
            };  
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;

            }
            return base.OnOptionsItemSelected(item);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void PrepareListdata()
        {
            listDataHeader = new List<ExpandedMenuModel>();
            List<ExpandedMenuModel> listSubmenu = new List<ExpandedMenuModel>();
            listDataChild = new Dictionary<ExpandedMenuModel, List<string>>();
            
            ExpandedMenuModel item1 = new ExpandedMenuModel();
            item1.Id = 1;
            item1.Name = "Introspect1";
            item1.Image = Resource.Drawable.mind_analysis;
            listDataHeader.Add(item1);

            ExpandedMenuModel item2 = new ExpandedMenuModel();
            item2.Id = 2;
            item2.Name = "Introspect2";
            item2.Image = Resource.Drawable.mind_analysis;
            listDataHeader.Add(item2);

            ExpandedMenuModel item3 = new ExpandedMenuModel();
            item3.Id = 3;
            item3.Name = "Introspect3";
            item3.Image = Resource.Drawable.mind_analysis;
            listDataHeader.Add(item3);

            ExpandedMenuModel item4 = new ExpandedMenuModel();
            item4.Id = 4;
            item4.Name = "Meditation";
            item4.Image = Resource.Drawable.meditation;
            listDataHeader.Add(item4);

            ExpandedMenuModel item5 = new ExpandedMenuModel();
            item5.Id = 5;
            item5.Name = "Maakolamai Vilainda MadhiVirundu";
            item5.Image = Resource.Drawable.Rangoli;
            listDataHeader.Add(item5);

            ExpandedMenuModel item6 = new ExpandedMenuModel();
            item6.Id = 6;
            item6.Name = "Vedhathriyam Songs";
            item6.Image = Resource.Drawable.song;
            listDataHeader.Add(item6);

            // Adding child data
            List<string> heading1 = new List<string>();
            heading1.Add("Tamil");
            heading1.Add("English");


            List<string> heading2 = new List<string>();
            heading2.Add("Morning");
            heading2.Add("Evening");             

            listDataChild.Add(listDataHeader[0], heading1);// Header, Child data
            listDataChild.Add(listDataHeader[1], heading1);
            listDataChild.Add(listDataHeader[2], heading1);
            listDataChild.Add(listDataHeader[3], heading2);
            listDataChild.Add(listDataHeader[4], null);
            listDataChild.Add(listDataHeader[5], null);



        }
    }
}