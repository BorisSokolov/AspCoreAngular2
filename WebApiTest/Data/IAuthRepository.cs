﻿using System.Threading.Tasks;
using DatingApp.Models;

namespace WebApiTest.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}
