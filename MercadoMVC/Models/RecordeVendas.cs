using MercadoMVC.Models.Enums;
using System;

namespace MercadoMVC.Models
{
    public class RecordeVendas
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Montante { get; set; }

        public StatusVendedor Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public RecordeVendas()
        {

        }

        public RecordeVendas(int id, DateTime data, double montante, StatusVendedor status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
