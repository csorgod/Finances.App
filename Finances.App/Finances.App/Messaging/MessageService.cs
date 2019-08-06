using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Messaging
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert(Resources.Resources.Error, message, Resources.Resources.Okay);
        }
    }
}
