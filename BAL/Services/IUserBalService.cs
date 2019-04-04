using BAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    /// <summary>
    /// реализовывает интерфейс пользователя
    /// </summary>
    public interface IUserBalService
    {
        /// <summary>
        /// регистрация пользователя
        /// </summary>
        /// /// <param name="user">пользователь</param>
        /// <param name="pass">пароль</param>
        Task<IdentityResult> Register(BUser user, string pass);
    }
}
