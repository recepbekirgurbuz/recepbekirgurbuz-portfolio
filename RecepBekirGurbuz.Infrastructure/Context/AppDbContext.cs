using Microsoft.EntityFrameworkCore;
using RecepBekirGurbuz.Core.Entities;

namespace RecepBekirGurbuz.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
