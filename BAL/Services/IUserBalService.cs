using BAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    /// <summary>
    /// Интерфейс пользователя
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
