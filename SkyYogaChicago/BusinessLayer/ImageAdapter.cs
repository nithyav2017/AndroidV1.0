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

namespace SkyYogaChicago.Class
{
    internal class ImageAdapter : BaseAdapter
    {
        private Activity __activity;

        string[] __name;
        string[] __author;
        int[] __imageId;
        int __textView;
        int __textviewAuthor;
        int __imageFlag;
        int __layout;

        public ImageAdapter(Activity activity, string[] name, string[] author, int[] imageId, int textView, int textViewAuthor, int imageFlag, int layout) //: base(activity,App5.Resource.Layout.Introspect1_main)
        {

            this.__activity = activity;
            this.__name = name;
            this.__author = author;
            this.__imageId = imageId;
            this.__textView = textView;
            this.__textviewAuthor = textViewAuthor;
            this.__imageFlag = imageFlag;
            this.__layout = layout;
        }
        public override int Count => __name.Length;

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = __activity.LayoutInflater.Inflate(__layout, null);
            }
            TextView txtViewName = view.FindViewById<TextView>(__textView);
            TextView txtViewAuthor = view.FindViewById<TextView>(__textviewAuthor);
            ImageView imageView = view.FindViewById<ImageView>(__imageFlag);
            Button button = view.FindViewById<Android.Widget.Button>(SkyYogaChicago.Resource.Id.backButton);

            txtViewName.SetText(__name[position], TextView.BufferType.Editable);
            txtViewAuthor.SetText(__author[position], TextView.BufferType.Normal);
            imageView.SetImageResource(__imageId[0]);
             

            return view;
        }
    }
}