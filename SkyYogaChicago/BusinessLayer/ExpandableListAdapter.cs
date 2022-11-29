using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SkyYogaChicago.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace SkyYogaChicago.BusinessLayer
{
    internal class ExpandableListAdapter: BaseExpandableListAdapter
    {
        private Activity _activity;
        private List<ExpandedMenuModel> _listDataHeader; // header titles

        private Dictionary<ExpandedMenuModel, List<string>> _listDataChild;
        ExpandableListView expandList;
         
        public ExpandableListAdapter(Activity context, List<ExpandedMenuModel> listDataHeader, Dictionary<ExpandedMenuModel, List<string>> listChildData, ExpandableListView mView)
        {
            _context = context;
            _listDataHeader = listDataHeader;
            _listDataChild = listChildData;
            expandList = mView;
        }

        public override int GroupCount
        {
            get
            {
                return _listDataHeader.Count;
            }
        }

        public override bool HasStableIds
        {
            get
            {
                return false;
            }
        }

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            return _listDataChild[_listDataHeader[groupPosition]][childPosition];
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            List<string> keyValue;

            if (_listDataChild.TryGetValue(_listDataHeader[groupPosition], out keyValue))
            {
                if (keyValue != null)
                {
                    int childCount = _listDataChild[_listDataHeader[groupPosition]].Count;
                    return childCount;
                }
            }
            return 0;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            string childText = (string)GetChild(groupPosition, childPosition);
            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(SkyYogaChicago.Resource.Layout.list_submenu, null);
            }
            TextView txtListChild = (TextView)convertView.FindViewById(Resource.Id.submenu);
            txtListChild.Text = childText;
            return convertView;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            return new JavaObjectWrapper<ExpandedMenuModel>() { Obj = _listDataHeader[groupPosition] };
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            ExpandedMenuModel headerTitle = _listDataHeader[groupPosition];

            convertView = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.list_header, null);
            TextView lblListHeader = (TextView)convertView.FindViewById(Resource.Id.submenu);
            ImageView headerIcon = (ImageView)convertView.FindViewById(Resource.Id.iconimage);
            lblListHeader.Text = headerTitle.Name;
            headerIcon.SetImageResource(headerTitle.Image);

            return convertView;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }

        public class JavaObjectWrapper<T> : Java.Lang.Object
        {
            public T Obj { get; set; }
        }
        private Activity _context { get; set; }

    }
}