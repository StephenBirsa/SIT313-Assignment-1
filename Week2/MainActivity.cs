using Android.App;
using Android.Widget;
using Android.OS;

namespace Week2
{
    [Activity(Label = "Assignment 1 Notepad App", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }
    }
}

