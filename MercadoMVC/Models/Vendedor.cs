using System;
using System.Collections.Generic;
using System.Linq;

namespace MercadoMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public double SalarioBase { get; set; }

        public Departamentos Departamentos { get; set; }

        public ICollection<RecordeVendas> Vendas { get; set; } = new List<RecordeVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamentos departamentos)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AddVendas (RecordeVendas sr)
        {
            Vendas.Add(sr);
        }

        public void RemoverVendas (RecordeVendas sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas (DateTime inicio, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicio && sr.Data <= final).Sum(sr => sr.Montante);
        }
    }
}
