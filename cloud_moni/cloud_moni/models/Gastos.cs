using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cloud_moni.models
{
    public class Gastos
    {
        [Key]
        public int IdGasto { get; set; }

        public int IdUsuario { get; set; }

        public string Categoria { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        public decimal Total { get; set; }
    }
}
