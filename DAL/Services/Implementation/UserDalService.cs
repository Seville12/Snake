using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Implementation
{
    internal class UserDalService : IUserDalService
    {
        private ApplicationDbContext _context;
        private readonly UserManager<DUser> _userManager;
        private readonly SignInManager<DUser> _signInManager;
        public UserDalService(ApplicationDbContext context, UserManager<DUser> userManager, SignInManager<DUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> Register(DUser user, string pass)
        {
            return await _userManager.CreateAsync(user, pass);
        }
    }
}
