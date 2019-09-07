using Finances.App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Finances.App.ViewModels
{
    public class FloatingActionButtonViewModel : BaseViewModel
    {
        public ICommand CreateFavoredCommand { get; }

        public FloatingActionButtonViewModel()
        {
            CreateFavoredCommand = new Command(async _ => await ExecuteCreateFavoredCommand());
        }

        public async Task ExecuteCreateFavoredCommand()
        {
            await _navigationService.NavigateTo(new CreateFavored());
        }
    }
}
