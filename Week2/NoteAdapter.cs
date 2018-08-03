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
        private Activity activity;
        private List<String> data;
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
            //Button button1 = view.FindViewById<Button>(Resource.Id.button1);
            //button1.Tag = name;
            //button1.SetOnClickListener(new ButtonClickListener(this.activity));
            return view;
        }
        private class ButtonClickListener : Java.Lang.Object, View.IOnClickListener
        {
            private Activity activity;
            public ButtonClickListener(Activity activity)
            {
                this.activity = activity;
            }
            public void OnClick(View view)
            {
                //string name = (string)view.Tag;
                //string text = string.Format("{0} Button Click.", name);
                //Toast.MakeText(this.activity, text, ToastLength.Short).Show();
                Intent intent = new Intent(this.activity, typeof(NoteEditor));
                this.activity.StartActivity(intent);
            }
        }
    }
}