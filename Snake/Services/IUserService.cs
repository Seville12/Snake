using Microsoft.AspNetCore.Identity;
using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Services
{
    /// <summary>
    /// реализовывает интерфейс пользователя
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// регистрация пользователя
        /// </summary>
        /// <returns></returns>
        Task<IdentityResult> Register(User user, string pass);
    }
}
