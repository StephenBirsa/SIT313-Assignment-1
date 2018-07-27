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
    [Activity(Label = "NoteEditor")]
    public class NoteEditor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Notepad);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                this.StartActivity(intent);
            };
        }
    }
}