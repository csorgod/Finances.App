using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Helpers.Messaging
{
    public class MessageService : IMessageService
    {
        public async Task ShowAlertAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert(Resources.Resources.Warning, message, Resources.Resources.Okay);
        }
        
        public async Task ShowErrorAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert(Resources.Resources.Error, message, Resources.Resources.Okay);
        }

        public async Task ShowMessageAsync(string message, string title)
        {
            await App.Current.MainPage.DisplayAlert(title, message, Resources.Resources.Okay);
        }
    }
}
