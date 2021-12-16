using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MercadoMVC.Models;

namespace MercadoMVC.Data
{
    public class MercadoMVCContext : DbContext
    {
        public MercadoMVCContext (DbContextOptions<MercadoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MercadoMVC.Models.Departamentos> Departamentos { get; set; }
    }
}
