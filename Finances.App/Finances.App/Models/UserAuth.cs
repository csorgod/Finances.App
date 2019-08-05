using System;
using System.Collections.Generic;
using System.Text;

namespace Finances.App.Models
{
    public class UserAuth
    {
        public string JwtToken { get; set; }
        public UserData User { get; set; }
    }
}
