using Finances.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finances.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        ProfileViewModel viewModel { get; set; }

        public Profile()
        {
            InitializeComponent();
            BindingContext = viewModel = new ProfileViewModel();
        }
    }
}