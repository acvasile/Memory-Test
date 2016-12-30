using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Memory_Test
{
    [Activity(Label = "Memory Test", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait,Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            

        }
    }
}

