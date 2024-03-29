﻿using System.Collections.Generic;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToUserList(List<ApplicationUser> usersEntity);
        UserListModel MaptoUserModel(ApplicationUser userEAtity);

    }
}
