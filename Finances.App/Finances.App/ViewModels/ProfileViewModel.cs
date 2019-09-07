using Finances.App.Helpers;
using Finances.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        UserData userAuth;

        public ProfileViewModel()
        {
            
        }

        public async Task GetDataAsync()
        {
            userAuth = await SessionHelper.GetLoggedUser();
        }
    }
}
