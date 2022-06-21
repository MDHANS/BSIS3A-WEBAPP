using bsisweb_app.Models;
using Microsoft.EntityFrameworkCore;

namespace bsisweb_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
        base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Type> Types { get; set; }
        
    }
}