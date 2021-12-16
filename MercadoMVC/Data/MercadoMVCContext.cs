using MercadoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MercadoMVC.Data
{
    public class MercadoMVCContext : DbContext
    {
        public MercadoMVCContext(DbContextOptions<MercadoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RecordeVendas> RecordeVendas { get; set; }
    }
}
