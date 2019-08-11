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
    public partial class TabbedPage : Xamarin.Forms.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();

            var dashboard = new Dashboard
            {
                IconImageSource = "ic_dashboard",
                Title = "Dashboard"
            };

            var favoreds = new Favoreds
            {
                IconImageSource = "ic_favoreds",
                Title = "Favorecidos"
            };

            var settings = new Settings
            {
                IconImageSource = "ic_settings",
                Title = "Configurações"
            };

            Children.Add(dashboard);
            Children.Add(favoreds);
            Children.Add(settings);
        }
    }
}