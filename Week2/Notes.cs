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
    [Activity(Label = "Notes")]
    public class Notes : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); List<string> data = new List<string>();
            data.Add("Reminders 2018");
            data.Add("Test 1");
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