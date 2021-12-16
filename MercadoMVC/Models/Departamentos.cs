using System;
using System.Collections.Generic;
using System.Linq;

namespace MercadoMVC.Models
{
    public class Departamentos
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamentos()
        {

        }

        public Departamentos(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor (Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas (DateTime inicio, DateTime final)
        {
            return Vendedores.Sum(seller => seller.TotalVendas(inicio, final));
        }
    }
}
