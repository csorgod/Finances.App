using Finances.App.Helpers;
using Finances.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Finances.App.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        UserData userAuth;

        #region Commands

        public ICommand EditCommand { get; }

        #endregion

        public ProfileViewModel()
        {
            EditCommand = new Command(async _ => await ExecuteEditCommand());
        }

        public async Task GetDataAsync()
        {
            //userAuth = await SessionHelper.GetLoggedUser();
        }

        public async Task ExecuteEditCommand()
        {

        }
    }
}
