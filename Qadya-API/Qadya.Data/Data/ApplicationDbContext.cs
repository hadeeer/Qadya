using Microsoft.EntityFrameworkCore;
using Qadya.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //(DbSet)
        public DbSet<User> Users { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
