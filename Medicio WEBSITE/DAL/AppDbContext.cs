using Medicio_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;

namespace Medicio_WEBSITE.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }
        
        public DbSet<Doctors> Doctors { get; set; }
    }
}
