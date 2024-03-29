﻿using Finances.App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Finances.App.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        #region Commands

        public ICommand ProfileCommand { get; }

        #endregion

        public DashboardViewModel()
        {
            ProfileCommand = new Command(_ => ExecuteOpenProfileCommand());
        }

        public async void ExecuteOpenProfileCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await _navigationService.NavigateTo(new Profile());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
