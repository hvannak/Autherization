using Autherization.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autherization.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                UserName = "vannak2010@gmail.com",
                NormalizedUserName = "vannak2010@gmail.com",
                Email = "vannak2010@gmail.com",
                NormalizedEmail = "vannak2010@gmail.com",
                PasswordHash = "AQAAAAEAACcQAAAAELJBSgZcx0bvVej9qoJz3FH7uR5pFMJ1fzv4cQEDNXaAfoRisrcGf/JOh2nwiTtO0w==",
                SecurityStamp = "YABAAQWF7PIGT7E4PUKC7H7EI774FZCO",
                FullName = "Vannak Heng"
            });
        }
    }
}
