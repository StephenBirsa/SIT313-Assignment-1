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
            base.OnCreate(savedInstanceState);
            List<string> data = new List<string>();
            LoadData(data);
            this.ListAdapter = new NoteAdapter(this, data);
        }
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            
            ISharedPreferences prefs = GetSharedPreferences(MainActivity.NOTES_PREFERENCES, FileCreationMode.Private);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutInt("NotePosition", position);
            editor.Apply();
            Intent intent = new Intent(this, typeof(NoteEditor));
            this.StartActivity(intent);
        }
        private void LoadData(List<string> data)
        {
            ISharedPreferences prefs = GetSharedPreferences(MainActivity.NOTES_PREFERENCES, FileCreationMode.Private);
            int size = prefs.GetInt("TitleSize", 0);
            for (int i = 0; i < size; i++)
            {
                data.Add(prefs.GetString("Titles_" + i, "Notes " + i));
            }
            if (size == 0)
            {
                Toast.MakeText(this, "You have no notes in your list!", ToastLength.Long).Show();
                Intent intent = new Intent(this, typeof(MainActivity));
                this.StartActivity(intent);
            }
        }
    }
}