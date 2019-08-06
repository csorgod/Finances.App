using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static Finances.App.Helpers.Enum;

namespace Finances.App.Models
{
    public class LoginInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [DefaultValue(LoginMode.App)]
        public LoginMode LoginMode { get; set; }
    }
}
