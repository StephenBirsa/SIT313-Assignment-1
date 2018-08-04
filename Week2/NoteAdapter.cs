using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Week2
{
    public class NoteAdapter : BaseAdapter<String>
    {
        public Activity activity;
        public List<String> data;
        public NoteAdapter(Activity activity, List<String> data)
        {
            this.activity = activity;
            this.data = data;
        }
        public override string this[int position]
        {
            get { return this.data[position]; }
        }
        public override int Count
        {
            get { return this.data.Count(); }
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
                view = this.activity.LayoutInflater.Inflate(Resource.Layout.ListLayout, null);
            }
            string str = this.data[position];
            string name = str;
            view.FindViewById<TextView>(Resource.Id.txtName).Text = name;
            return view;
        }
    }
}