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
using Android.Net;

using Xamarin.Forms;
using StoreRating.Forms.Plugin.Abstractions;

[assembly: Dependency(typeof(StoreRating.Forms.Plugin.Droid.RatingService))]

namespace StoreRating.Forms.Plugin.Droid
{
    public class RatingService : IRatingService
    {
        public void ShowStore(string id = "", bool IsAmazon = false)
        {
            Intent intent = new Intent("android.intent.action.VIEW");
            if (IsAmazon)
                intent.SetData(Android.Net.Uri.Parse("amzn://apps/android?p=" + Application.Context.PackageName));
            else
                intent.SetData(Android.Net.Uri.Parse("market://details?id=" + Application.Context.PackageName));
            intent.SetFlags(ActivityFlags.NewTask);
            Xamarin.Forms.Forms.Context.StartActivity(intent);
        }
        public static void Init() { }
    }
}