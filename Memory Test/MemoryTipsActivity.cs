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

namespace Memory_Test
{
    [Activity(Label = "MemoryTipsActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, Icon = "@drawable/ic_launcher")]
    public class MemoryTipsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.MemoryTips);
        }
    }
}