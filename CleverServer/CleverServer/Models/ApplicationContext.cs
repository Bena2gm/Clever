using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverServer.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Question> Questions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            :base(options)
        {
            Database.EnsureCreated();
        }

    }
}
