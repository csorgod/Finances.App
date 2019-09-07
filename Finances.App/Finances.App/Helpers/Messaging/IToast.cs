using System;
using System.Collections.Generic;
using System.Text;
using static Finances.App.Helpers.Enum;

namespace Finances.App.Helpers.Messaging
{
    public interface IToast
    {
        void MakeText(string message, ToastLength length);
    }
}
