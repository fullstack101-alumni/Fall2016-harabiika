using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RASchedule.Models
{
    public class RaContext : DbContext
    {
        public RaContext(DbContextOptions<RaContext> options) : base(options){ }
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

        public int userId { get; set; }
        public User User { get; set; }
    }
}
