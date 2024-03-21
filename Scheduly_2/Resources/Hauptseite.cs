using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduly_2.Resources
{
    [Activity(Label = "Hauptseite")]
    public class Hauptseite : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        
            SetContentView(Resource.Layout.activity_main);

        }
    }
}