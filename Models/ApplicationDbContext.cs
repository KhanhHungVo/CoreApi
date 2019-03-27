using CoreApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Manually define list models for EF core creates table that have same name as the DBset property names
        public DbSet<User> Users { get; set; }

        public DbSet<Coin> Coins { get; set; }
    }
}
