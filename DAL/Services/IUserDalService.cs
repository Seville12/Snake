using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    /// <summary>
    /// Интерфейс пользователя
    /// </summary>
    public interface IUserDalService
    {
        /// <summary>
        /// регистрация пользователя
        /// </summary>
        /// <returns></returns>
        Task<IdentityResult> Register(DUser user, string pass);
    }
}
