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
        public ICommand Register { get; }
        public ICommand ForgotPassword { get; }

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
            Register = new Command(async () => await ExecuteRegisterCommand());
            ForgotPassword = new Command(async () => await ExecuteForgotPasswordCommand());
        }

        private async Task ExecuteLoginCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                var login = await new AuthService().Login(loginInfo);
            }
            catch (Exception ex)
            {
                await _messageService.ShowAsync("Algo deu errado ao tentar autenticar: " + ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private Task ExecuteRegisterCommand()
        {
            throw new NotImplementedException();
        }

        private Task ExecuteForgotPasswordCommand()
        {
            throw new NotImplementedException();
        }

    }
}
