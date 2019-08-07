using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Helpers.Messaging
{
    public interface IMessageService
    {
        Task ShowErrorAsync(string message);
        Task ShowMessageAsync(string message, string title);
        Task ShowAlertAsync(string message);
    }
}
