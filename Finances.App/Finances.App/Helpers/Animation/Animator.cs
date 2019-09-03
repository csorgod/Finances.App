using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Finances.App.Helpers.Animation
{
    public static class Animator
    {
        public async static Task FAB_Rotate90Degrees(Button fab)
        {
            await fab.RotateTo(315, easing: Easing.Linear);
        }

        public async static Task FAB_RotateBack90Degrees(Button fab)
        {
            await fab.RotateTo(0, easing: Easing.Linear);
        }
    }
}
