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

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand NewFavoredCommand { get; }

        #endregion

        #region Properties

        public IEnumerable<Favored> Favoreds { get; private set; }

        #endregion

        public FavoredViewModel()
        {
            EditCommand = new Command<Favored>(async (model) => await ExecuteEditFavoredCommand(model));
            DeleteCommand = new Command<Guid>(async (id) => await ExecuteDeleteFavoredCommand(id));
            NewFavoredCommand = new Command(async _ => await ExecuteNewFavoredCommand());

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

        public async Task ExecuteNewFavoredCommand()
        {
            
        }

        public async Task ExecuteEditFavoredCommand(Favored favored)
        {

        }

        public async Task ExecuteDeleteFavoredCommand(Guid Id)
        {

        }
    }
}
