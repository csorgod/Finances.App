using Finances.App.Helpers;
using Finances.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Services
{
    public class AuthService : BaseService
    {
        public AuthService()
        { }

        public async Task<JsonDefaultResponse<UserAuth>> Login(LoginInfo loginInfo)
        {
            return await HttpClient.Post<UserAuth>("auth/login", loginInfo);
        }
    }
}
