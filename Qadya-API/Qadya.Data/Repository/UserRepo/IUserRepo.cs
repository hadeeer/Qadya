using Microsoft.EntityFrameworkCore.Migrations;
using Qadya.Data.Models;
using Qadya.Data.Repository.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data
{
    public interface IUserRepo:IRepo<User, int>
    {
        Task<User> GetByEmailAsync(string email);

    }
}
