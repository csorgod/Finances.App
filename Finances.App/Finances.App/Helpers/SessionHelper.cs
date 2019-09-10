using Finances.App.Models;
using System;
using System.Threading.Tasks;
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
                await SecureStorage.SetAsync("id", _userLogged.User.Id);
                await SecureStorage.SetAsync("userName", _userLogged.User.Username);
                await SecureStorage.SetAsync("name", _userLogged.User.Name);
                await SecureStorage.SetAsync("lastName", _userLogged.User.LastName);
                await SecureStorage.SetAsync("phoneNumber", _userLogged.User.PhoneNumber);
                await SecureStorage.SetAsync("email", _userLogged.User.Email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async static Task<UserData> GetLoggedUser()
        {
            return _userLogged.User;
        }

        public static void Logout()
        {
            SecureStorage.RemoveAll();
        }
    }
}
