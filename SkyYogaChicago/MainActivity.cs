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

namespace SkyYogaChicago
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        NavigationView navigationView;
        ActionBarDrawerToggle actionBarDrawerToggle;
        SearchView searchView;
        Intent intent;
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
            navigationView = FindViewById<NavigationView>(SkyYogaChicago.Resource.Id.nav_view);

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
    }
}