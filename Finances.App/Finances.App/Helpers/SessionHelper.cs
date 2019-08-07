using Finances.App.Models;
using System;
using Xamarin.Essentials;

namespace Finances.App.Helpers
{
    public static class SessionHelper
    {
        private static UserAuth _userLogged;

        public async static void Login(UserAuth login)
        {
            try
            {
                _userLogged = login;
                await SecureStorage.SetAsync("jwtToken", _userLogged.JwtToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static UserData GetLoggedUser()
        {
            return _userLogged.User;
        }

        public static void Logout()
        {
            SecureStorage.RemoveAll();
        }
    }
}
