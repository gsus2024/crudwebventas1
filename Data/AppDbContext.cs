using crudwebventas1.Models;
using Microsoft.EntityFrameworkCore;

namespace crudwebventas1.Data
{
    public class AppDbCOntext:DbContext{
        public AppDbCOntext(DbContextOptions<AppDbCOntext> options):base(options) { }
        public DbSet<Familia> Familias { get; set;}
    }
}