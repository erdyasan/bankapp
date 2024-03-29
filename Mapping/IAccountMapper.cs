﻿using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        Account AccountCreateModelToAccount(AccountCreateModel model);
    }
}
