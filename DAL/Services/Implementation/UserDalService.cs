using DAL.Data;
using DAL.Models;
using DAL.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Services.Implementation
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
    }
}
