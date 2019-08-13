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

            var en = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Alimentação",
                    ValueLabel = "200",
                    Color = SkiaSharp.SKColor.Parse("#ec2927")
                },

                new Microcharts.Entry(150)
                {
                    Label = "Luz",
                    ValueLabel = "150",
                    Color = SkiaSharp.SKColor.Parse("#f14a26")
                },

                new Microcharts.Entry(250)
                {
                    Label = "Roupas",
                    ValueLabel = "250",
                    Color = SkiaSharp.SKColor.Parse("#f1752f")
                },

                new Microcharts.Entry(59)
                {
                    Label = "Gás",
                    ValueLabel = "59",
                    Color = SkiaSharp.SKColor.Parse("#fba13c")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Água",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fcd119")
                },

                new Microcharts.Entry(210)
                {
                    Label = "Telefone",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fdec00")
                },

                new Microcharts.Entry(78)
                {
                    Label = "TV",
                    ValueLabel = "89",
                    Color = SkiaSharp.SKColor.Parse("#c0d724")
                },

                new Microcharts.Entry(125)
                {
                    Label = "Viagem",
                    ValueLabel = "358",
                    Color = SkiaSharp.SKColor.Parse("#88c540")
                }
            };

            SpendingByCategoriesChart.Chart = new Microcharts.RadarChart
            {
                PointMode = Microcharts.PointMode.Square,
                PointSize = 15,
                BackgroundColor = SkiaSharp.SKColors.Transparent,
                LabelTextSize = 30,
                MaxValue = en.Max(e => e.Value) + 50,
                MinValue = en.Min(e => e.Value) - 50,
                Entries = en
            };

            var entries = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Jan",
                    ValueLabel = "200",
                    Color = SkiaSharp.SKColor.Parse("#ec2927")
                },

                new Microcharts.Entry(150)
                {
                    Label = "Fev",
                    ValueLabel = "150",
                    Color = SkiaSharp.SKColor.Parse("#f14a26")
                },

                new Microcharts.Entry(250)
                {
                    Label = "Mar",
                    ValueLabel = "250",
                    Color = SkiaSharp.SKColor.Parse("#f1752f")
                },

                new Microcharts.Entry(59)
                {
                    Label = "Abr",
                    ValueLabel = "59",
                    Color = SkiaSharp.SKColor.Parse("#fba13c")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Mai",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fcd119")
                },

                new Microcharts.Entry(471)
                {
                    Label = "Jun",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#fdec00")
                },

                new Microcharts.Entry(78)
                {
                    Label = "Jul",
                    ValueLabel = "89",
                    Color = SkiaSharp.SKColor.Parse("#c0d724")
                },

                new Microcharts.Entry(125)
                {
                    Label = "Ago",
                    ValueLabel = "358",
                    Color = SkiaSharp.SKColor.Parse("#88c540")
                },

                new Microcharts.Entry(378)
                {
                    Label = "Set",
                    ValueLabel = "114",
                    Color = SkiaSharp.SKColor.Parse("#48ac40")
                },

                new Microcharts.Entry(250)
                {
                    Label = "Out",
                    ValueLabel = "25",
                    Color = SkiaSharp.SKColor.Parse("#029343")
                },

                new Microcharts.Entry(174)
                {
                    Label = "Nov",
                    ValueLabel = "174",
                    Color = SkiaSharp.SKColor.Parse("#1791a8")
                },

                new Microcharts.Entry(87)
                {
                    Label = "Dez",
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
                MaxValue = entries.Max(e => e.Value) + 50,
                MinValue = entries.Min(e => e.Value) - 50,
                Entries = entries
            };
        }
    }
}