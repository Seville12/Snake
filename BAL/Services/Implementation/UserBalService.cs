using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BAL.Models;
using DAL.Models;
using DAL.Services;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace BAL.Services.Implementation
{
    internal class UserBalService : IUserBalService
    {
        private readonly IUserDalService userBalServise;

        public UserBalService(IUserDalService userBalService)
        {
            this.userBalServise = userBalServise;
        }


        public async Task<IdentityResult> Register(BUser user, string pass)
        {
            var userD = user.Adapt<DUser>();
            return await this.userBalServise.Register(userD, pass);
        }
    }
}
