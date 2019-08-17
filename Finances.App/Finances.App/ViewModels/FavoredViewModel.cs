﻿using Finances.App.Models;
using Finances.App.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Finances.App.ViewModels
{
    public class FavoredViewModel : BaseViewModel
    {
        #region Commands

        public ICommand NewFavoredCommand { get; }

        #endregion

        #region Properties

        public IEnumerable<Favored> Favoreds { get; private set; }

        #endregion

        public FavoredViewModel()
        {
            NewFavoredCommand = new Command(async _ => await NewFavored());

            //Favoreds = new FavoredService().GetFavoredByUser();
            Favoreds = new List<Favored>
            {
                new Favored
                {
                    Id = Guid.NewGuid(),
                    Name = "Adebaior da Silva",
                    TaxNumber = "427.174.187-15",
                    BelongToUserId = Guid.NewGuid(),
                    CreatedAt = DateTime.Now.AddDays(-3),
                    Account = new Account
                    {
                        Bank = 123,
                        BankAccount = 12345,
                        BankBranch = 2344,
                        BankAccountDigit = 1
                    }
                },

                new Favored
                {
                    Id = Guid.NewGuid(),
                    Name = "Adebaior da Silva",
                    TaxNumber = "427.174.187-15",
                    BelongToUserId = Guid.NewGuid(),
                    CreatedAt = DateTime.Now.AddDays(-3),
                    Account = new Account
                    {
                        Bank = 123,
                        BankAccount = 12345,
                        BankBranch = 2344,
                        BankAccountDigit = 1
                    }
                },

                new Favored
                {
                    Id = Guid.NewGuid(),
                    Name = "Adebaior da Silva",
                    TaxNumber = "427.174.187-15",
                    BelongToUserId = Guid.NewGuid(),
                    CreatedAt = DateTime.Now.AddDays(-3),
                    Account = new Account
                    {
                        Bank = 123,
                        BankAccount = 12345,
                        BankBranch = 2344,
                        BankAccountDigit = 1
                    }
                }
            };
        }

        public async Task NewFavored()
        {
            
        }
    }
}