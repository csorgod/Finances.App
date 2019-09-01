using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Themes = Xamarin.Forms.Themes;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Animation;
using Xamarin.Forms.Platform.Android;

namespace Finances.App.Droid
{
    [Activity(Label = "Finances.App", Icon = "@mipmap/ic_launcher_square", RoundIcon = "@mipmap/ic_launcher_circle", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        private static bool isFabOpen;
        private FloatingActionButton fabTertiary;
        private FloatingActionButton fabSecondary;
        private FloatingActionButton fabPrimary;
        private View fabMenu;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            fabTertiary = FindViewById<FloatingActionButton>(Resource.Id.fab_tertiary);
            fabSecondary = FindViewById<FloatingActionButton>(Resource.Id.fab_secondary);
            fabPrimary = FindViewById<FloatingActionButton>(Resource.Id.fab_primary);
            fabMenu = FindViewById<View>(Resource.Id.fab_menu);

            fabPrimary.Click += (o, e) =>
            {
                if (!isFabOpen)
                    ShowFabMenu();
                else
                    CloseFabMenu();
            };

            fabSecondary.Click += (o, e) =>
            {
                CloseFabMenu();
                Toast.MakeText(this, "Cake!", ToastLength.Short).Show();
            };

            fabTertiary.Click += (o, e) =>
            {
                CloseFabMenu();
                Toast.MakeText(this, "Airballoon!", ToastLength.Short).Show();
            };

            fabMenu.Click += (o, e) => CloseFabMenu();


            var x = typeof(Themes.DarkThemeResources);
            x = typeof(Themes.DarkThemeResources);
            x = typeof(Themes.Android.UnderlineEffect);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void ShowFabMenu()
        {
            isFabOpen = true;
            fabTertiary.Visibility = ViewStates.Visible;
            fabSecondary.Visibility = ViewStates.Visible;
            fabMenu.Visibility = ViewStates.Visible;

            fabPrimary.Animate().Rotation(135f);
            fabMenu.Animate().Alpha(1f);
            fabTertiary.Animate()
                .TranslationY(-Resources.GetDimension(Resource.Dimension.standard_100))
                .Rotation(0f);
            fabSecondary.Animate()
                .TranslationY(-Resources.GetDimension(Resource.Dimension.standard_55))
                .Rotation(0f);
        }

        private void CloseFabMenu()
        {
            isFabOpen = false;

            fabPrimary.Animate().Rotation(0f);
            fabMenu.Animate().Alpha(0f);
            fabTertiary.Animate()
                .TranslationY(0f)
                .Rotation(90f);
            fabSecondary.Animate()
                .TranslationY(0f)
                .Rotation(90f).SetListener(new FabAnimatorListener(fabMenu, fabSecondary, fabTertiary));
        }

        private class FabAnimatorListener : Java.Lang.Object, Animator.IAnimatorListener
        {
            View[] viewsToHide;

            public FabAnimatorListener(params View[] viewsToHide)
            {
                this.viewsToHide = viewsToHide;
            }

            public void OnAnimationCancel(Animator animation)
            {
            }

            public void OnAnimationEnd(Animator animation)
            {
                if (!isFabOpen)
                    foreach (var view in viewsToHide)
                        view.Visibility = ViewStates.Gone;
            }

            public void OnAnimationRepeat(Animator animation)
            {
            }

            public void OnAnimationStart(Animator animation)
            {
            }
        }
    }
}