using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860


    // NOT MIGRATED
namespace ratry.Models
{
        public class RaContext : DbContext
        {
            public RaContext(DbContextOptions<RaContext> options) : base(options) { }
            public DbSet<User> Users { get; set; }
            public DbSet<Duty> Duties { get; set; }
        }

        public class User
        {
            public int userId { get; set; }
            public string name { get; set; }
            public string email { get; set; }
        }

        public class Duty
        {
            public int dutyId { get; set; }
            public string DutyDays { get; set; }
            public int DutyHours { get; set; }

            public int userId { get; set; }
            public User User { get; set; }
        }
}
