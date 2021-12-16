using MercadoMVC.Models;
using MercadoMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoMVC.Data
{
    public class SeedingService
    {
        private MercadoMVCContext _context;

        public SeedingService(MercadoMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamentos.Any() || _context.Vendedor.Any() || _context.RecordeVendas.Any())
            {
                return; //banco populado
            }

            Departamentos d1 = new Departamentos(1, "Computador");
            Departamentos d2 = new Departamentos(2, "Eletronicos");
            Departamentos d3 = new Departamentos(3, "Livros");

            Vendedor s1 = new Vendedor(1, "Matheus", "Matheus@gmail.com", new DateTime(1999, 4, 21), 1000.00, d1);
            Vendedor s2 = new Vendedor(2, "Pedro", "Pedro@gmail.com", new DateTime(1989, 5, 24), 1050.00, d2);
            Vendedor s3 = new Vendedor(3, "João", "João@gmail.com", new DateTime(1997, 10, 11), 2500.00, d3);

            RecordeVendas r1 = new RecordeVendas(1, new DateTime(2017, 11, 12), 1203.00, StatusVendedor.Faturado, s1);
            RecordeVendas r2 = new RecordeVendas(2, new DateTime(2019, 04, 07), 1474.00, StatusVendedor.Cancelado, s3);
            RecordeVendas r3 = new RecordeVendas(3, new DateTime(2018, 01, 03), 1743.00, StatusVendedor.Faturado, s2);
            RecordeVendas r4 = new RecordeVendas(4, new DateTime(2019, 12, 09), 2103.00, StatusVendedor.Pendente, s1);
            RecordeVendas r5 = new RecordeVendas(5, new DateTime(2018, 03, 23), 7403.00, StatusVendedor.Faturado, s2);

            _context.Departamentos.AddRange(d1, d2, d3);

            _context.Vendedor.AddRange(s1, s2, s3);

            _context.RecordeVendas.AddRange(r1, r2, r3, r4, r5);

            _context.SaveChanges();
        }
    }
}
