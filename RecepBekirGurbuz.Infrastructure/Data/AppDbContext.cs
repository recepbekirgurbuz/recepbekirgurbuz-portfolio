using Microsoft.EntityFrameworkCore;
using RecepBekirGurbuz.Core.Entities;
using System.Collections.Generic;

namespace RecepBekirGurbuz.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
