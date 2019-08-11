﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Finances.App.Helpers.Navigation
{
    public class NavigationService : INavigationService 
    {
        public async Task NavigateTo(Page page)
        {
            await App.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
