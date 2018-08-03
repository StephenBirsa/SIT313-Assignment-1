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

            ISharedPreferences prefs = GetSharedPreferences(MainActivity.NOTES_PREFERENCES, FileCreationMode.Private);
            int size = 0;
            if (prefs.GetInt("NotePosition", 0) == -1)
            {
                size = prefs.GetInt("TitleSize", 0);
            }
            else
            {
                size = prefs.GetInt("NotePosition", 0);
            }
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView1.Text = prefs.GetString("Titles_" + size, "Notes " + size);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                this.StartActivity(intent);
            };
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate
            {
                SaveData(textView1);
            };
        }
        private void SaveData(TextView textView1)
        {
            ISharedPreferences prefs = GetSharedPreferences(MainActivity.NOTES_PREFERENCES, FileCreationMode.Private);
            ISharedPreferencesEditor editor = prefs.Edit();
            int size = prefs.GetInt("TitleSize", 0);
            if (prefs.GetInt("NotePosition", -1) == -1)
            {
                editor.PutString("Titles_" + size, "Notes " + size);
                size = size + 1;
                editor.PutInt("TitleSize", size);
            }
            else
            {
                size = prefs.GetInt("NotePosition", 0);
                editor.PutString("Titles_" + size, "Notes " + size);
            }
            editor.Apply();
        }
    }
}