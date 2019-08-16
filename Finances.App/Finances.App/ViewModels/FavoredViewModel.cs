using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Finances.App.ViewModels
{
    public class FavoredViewModel : BaseViewModel
    {
        #region Commands

        public ICommand NewFavoredCommand { get; }

        #endregion
    }
}
