using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using Android.Views;

namespace Week2
{
    [Activity(Label = "Assignment 1 Notepad App", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            List<string> data = new List<string>();
            data.Add("Reminders 2018");
            data.Add("Chris's Weebo Top 10 List");
            this.ListAdapter = new NoteAdapter(this, data);
        }
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            //string str = ((NoteAdapter)this.ListAdapter)[position];
            //string text = string.Format("{0} Item Click!", str);
        }
    }
}

