﻿using System.Threading.Tasks;
using WebApiTest.Models;

namespace WebApiTest.Data
{
    interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExistsAsync(string username);

    }
}
