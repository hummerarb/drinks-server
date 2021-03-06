﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drinks.Entities;
using Drinks.Repository;
using Drinks.Services;

namespace Drinks.Tests
{
    using System;
    using Drinks.Api.Controllers;
    using Drinks.Entities.Extensions;

    [TestClass]
    public class TaskMethods
    {
        [TestMethod]
        public void CreateUser()
        {
            var user = new User
            {
                Username = "levi.botelho",
                IsAdmin = true,
                Name = "Levi Botelho"
            };

            var uow = new UnitOfWork(new DrinksContext());
            var userService = new UserService(uow, new PasswordHelper());
            userService.CreateUser(user, "test");
            uow.Dispose();
        }
    }
}