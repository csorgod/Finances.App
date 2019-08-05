using Finances.App.Models;
using Finances.App.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Finances.App.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {

        #region Commands

        public ICommand Login { get; }

        #endregion

        #region Properties

        private LoginInfo loginInfo;

        public LoginInfo LoginInfo
        {
            get { return loginInfo; }
            set { loginInfo = value; }
        }

        #endregion

        public SignInViewModel()
        {
            Login = new Command(async () => await ExecuteLoginCommand());
        }

        private async Task ExecuteLoginCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await new AuthService().Login(loginInfo);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
