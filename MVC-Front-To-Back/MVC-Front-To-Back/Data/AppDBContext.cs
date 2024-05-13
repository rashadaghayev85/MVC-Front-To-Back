using Microsoft.EntityFrameworkCore;
using MVC_Front_To_Back.Models;

namespace MVC_Front_To_Back.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Car>Cars { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
