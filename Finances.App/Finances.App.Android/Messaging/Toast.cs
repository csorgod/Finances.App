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
using Finances.App.Helpers;
using Finances.App.Helpers.Messaging;

[assembly: Xamarin.Forms.Dependency(typeof(Finances.App.Droid.Messaging.Toast))]
namespace Finances.App.Droid.Messaging
{
    public class Toast : IToast
    {
        public void MakeText(string message, Helpers.Enum.ToastLength length)
        {
            Android.Widget.Toast.MakeText(Application.Context, message, length == Helpers.Enum.ToastLength.Long ? ToastLength.Long : ToastLength.Short).Show();
        }
    }
}