using Finances.App.Helpers.Messaging;
using Finances.App.Helpers.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Enum = Finances.App.Helpers.Enum;
using Resx = Finances.App.Resources;

namespace Finances.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage : Xamarin.Forms.TabbedPage
    {
        private int BackPressedCount = 0;

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

            var bills = new BillsToPay
            {
                IconImageSource = "ic_bills",
                Title = "Contas"
            };

            var incomings = new Incomings
            {
                IconImageSource = "ic_wallet",
                Title = "Rendas"
            };

            var settings = new Settings
            {
                IconImageSource = "ic_settings",
                Title = "Configurações"
            };

            Children.Add(dashboard);
            Children.Add(favoreds);
            Children.Add(bills);
            Children.Add(incomings);
            Children.Add(settings);
        }

        protected override bool OnBackButtonPressed()
        {
            BackPressedCount++;

            if (BackPressedCount < 2)
                DependencyService.Get<IToast>().MakeText(Resx.Resources.PressAgainToExit, Enum.ToastLength.Short);
            else
                DependencyService.Get<IApplicationBehaviour>().CloseApplication();

            return true;
        }

        protected override void OnCurrentPageChanged()
        {
            BackPressedCount = 0;

            base.OnCurrentPageChanged();
        }
    }
}