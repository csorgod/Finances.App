using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Finances.App.Helpers.Navigation
{
    public interface INavigationService
    {
        Task NavigateTo(Page page, object[] args = null);
    }
}
