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
using Finances.App.Droid.Navigation;
using Finances.App.Helpers.Navigation;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ApplicationBehaviour))]
namespace Finances.App.Droid.Navigation
{
    public class ApplicationBehaviour : IApplicationBehaviour
    {
        public void CloseApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}