using Finances.App.Helpers;
using Finances.App.Models;
using Finances.App.Services;
using Finances.App.Views;
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

        private LoginInfo _loginInfo;

        public LoginInfo LoginInfo
        {
            get { return _loginInfo; }
            set { _loginInfo = value; }
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
                //var response = await new AuthService().Login(_loginInfo);

                //if (!response.Success)
                //    throw new Exception(response.Message);

                //else
                //{
                //    SessionHelper.Login(response.Payload);
                    await _navigationService.NavigateTo(new Views.TabbedPage());
                //}
            }
            catch (Exception ex)
            {
                await _messageService.ShowErrorAsync("Algo deu errado ao tentar autenticar: " + ex.Message);
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
