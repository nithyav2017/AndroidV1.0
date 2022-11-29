using Android.App;
using Android.Content;
using System;

namespace SkyYogaChicago.SharedLibrary
{
    public class ActivityReference : Activity, IActivityReference
    { 
         
        Context _context;
        public ActivityReference()
        {

        }

        public ActivityReference(Context context )
        {
          
            this._context = context;
        }
        public void CallIntrospectActivity()
        {
            Intent intent = new Intent(_context, typeof(Introspect));
            StartActivity(intent);
        }
    }
}
