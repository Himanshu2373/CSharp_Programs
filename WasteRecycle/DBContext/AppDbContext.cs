using Microsoft.EntityFrameworkCore;
using WasteRecycle.Models;

namespace WasteRecycle.DBContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
      
        public DbSet<ApplicationUser> applicationUser { get; set; }
    }
}
