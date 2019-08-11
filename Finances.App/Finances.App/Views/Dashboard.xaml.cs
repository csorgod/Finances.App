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
    public partial class Dashboard : ContentPage
    {
        DashboardViewModel viewModel;
        public Dashboard()
        {
            InitializeComponent();

            BindingContext = this.viewModel = new DashboardViewModel();

            //TODO: Remove after finish API implementation

            var entries = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Janeiro",
                    ValueLabel = "200",
                    Color = SkiaSharp.SKColor.Parse("#ec2927")
                },

                new Microcharts.Entry(150)
                {
                    Label = "Fevereiro",
                    ValueLabel = "150",
                    Color = SkiaSharp.SKColor.Parse("#f14a26")
                },

                new Microcharts.Entry(250)
                {
                    Label = "Março",
                    ValueLabel = "250",
                    Color = SkiaSharp.SKColor.Parse("#f1752f")
                },

                new Microcharts.Entry(59)
                {
                    Label = "Abril",
                    ValueLabel = "59",
                    Color = SkiaSharp.SKColor.Parse("#fba13c")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Maio",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fcd119")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Junho",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fdec00")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Julho",
                    ValueLabel = "89",
                    Color = SkiaSharp.SKColor.Parse("#c0d724")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Agosto",
                    ValueLabel = "358",
                    Color = SkiaSharp.SKColor.Parse("#88c540")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Setembro",
                    ValueLabel = "114",
                    Color = SkiaSharp.SKColor.Parse("#48ac40")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Outubro",
                    ValueLabel = "25",
                    Color = SkiaSharp.SKColor.Parse("#029343")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Novembro",
                    ValueLabel = "174",
                    Color = SkiaSharp.SKColor.Parse("#1791a8")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Dezembro",
                    ValueLabel = "220",
                    Color = SkiaSharp.SKColor.Parse("#288ae1")
                },

            };

            Chart.Chart = new Microcharts.LineChart
            {
                PointMode = Microcharts.PointMode.Square,
                PointSize = 15,
                BackgroundColor = SkiaSharp.SKColors.Transparent,
                LineMode = Microcharts.LineMode.Straight,
                Entries = entries
            };
        }
    }
}