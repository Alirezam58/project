using Project.core.Interfaces;
using Project.datalayer.Context;
using Project.datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Project.core.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public int GetUserRole(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if(user != null)
            {
                return user.RoleId;
            }

            return 0;
            
        }
    }
}
