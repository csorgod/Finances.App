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
    public partial class FavoredDetails : ContentPage
    {
        FavoredDetailsViewModel viewModel;
        public FavoredDetails()
        {
            InitializeComponent();

            BindingContext = viewModel = new FavoredDetailsViewModel();
        }
    }
}