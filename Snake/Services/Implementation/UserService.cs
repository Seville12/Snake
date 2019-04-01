using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Models;
using BAL.Services;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Snake.Models;

namespace Snake.Services.Implementation
{
    internal class UserService : IUserService
    {
        private readonly IUserBalService userData;
        
        public UserService(IUserBalService userData)
        {
            this.userData = userData;
        }

        public  async Task<IdentityResult> Register(User user, string pass)
        {
            var userV = user.Adapt<BUser>();
            return (await this.userData.Register(userV, pass)).Adapt<IdentityResult>();

        }
    }
}
