using BackendPru.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPru.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
