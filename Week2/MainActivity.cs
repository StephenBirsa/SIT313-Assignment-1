using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using Android.Views;

namespace Week2
{
    [Activity(Label = "Assignment 1 Notepad App", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Notes));
                this.StartActivity(intent);
            };
        }
    }
}