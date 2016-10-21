using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ratry.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class

    public class ApplicationUser : IdentityUser
    {
        public string aubgnumber { get; set; }
        public DbSet<Duty> Duty { get; set; }



        // var context = HttpContext.Current.GetOwinContext().Get<ApplicationDbContext>();
    }

    public class Duty
    {
        [Key]
        public Guid DutyId { get; set; }

        public string name { get; set; }
        public string day { get; set; }
        public int hour { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}