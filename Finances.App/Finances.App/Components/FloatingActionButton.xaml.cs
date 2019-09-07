using Finances.App.Helpers.Animation;
using Finances.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finances.App.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FloatingActionButton : ContentView
    {
        bool IsActive { get; set; } = false;

        FloatingActionButtonViewModel viewModel { get; set; }

        public FloatingActionButton()
        {
            InitializeComponent();
            BindingContext = viewModel = new FloatingActionButtonViewModel();
        }

        private async void FABPrimary_Clicked(object sender, EventArgs e)
        {
            if(!IsActive)
                await Animator.FAB_Rotate90Degrees(sender as Button);
            else 
                await Animator.FAB_RotateBack90Degrees(sender as Button);

            IsActive = !IsActive;
        }
    }
}