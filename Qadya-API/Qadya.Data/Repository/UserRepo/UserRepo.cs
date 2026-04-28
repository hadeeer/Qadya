using Microsoft.EntityFrameworkCore;
using Qadya.Data.Data;
using Qadya.Data.Models;
using Qadya.Data.Repository.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data
{
    internal class UserRepo : Repo<User, int>, IUserRepo
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        }
    }
}
