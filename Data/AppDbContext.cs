using appventas.Models;
using Microsoft.EntityFrameworkCore;

namespace appventas.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
        public DbSet<Familia> Familias { get; set; }
    }
}