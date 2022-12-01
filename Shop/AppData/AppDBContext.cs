using Microsoft.EntityFrameworkCore;
using Shop.AppData.Models;
using System.Security.Permissions;

namespace Shop.AppData
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
