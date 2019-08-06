using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Messaging
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
