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

            var entries = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Janeiro",
                    ValueLabel = "200",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(150)
                {
                    Label = "Janeiro",
                    ValueLabel = "150",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(250)
                {
                    Label = "Janeiro",
                    ValueLabel = "250",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(59)
                {
                    Label = "Janeiro",
                    ValueLabel = "59",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
                },

                new Microcharts.Entry(187)
                {
                    Label = "Janeiro",
                    ValueLabel = "187",
                    Color = SkiaSharp.SKColor.Parse("#266489")
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