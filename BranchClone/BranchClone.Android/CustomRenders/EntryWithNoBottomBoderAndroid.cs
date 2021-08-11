using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BranchClone.CustomRenders;
using BranchClone.Droid.CustomRenders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(EntryWithNoBottomBoder),typeof(EntryWithNoBottomBoderAndroid))]
namespace BranchClone.Droid.CustomRenders
{

    public class EntryWithNoBottomBoderAndroid : EntryRenderer
    {
        public EntryWithNoBottomBoderAndroid(Context context):base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}