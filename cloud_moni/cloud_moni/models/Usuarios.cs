using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cloud_moni.models
{
    public class Usuarios
       
    {   
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        //public ICollection<Gastos> Gastos { get; set; }
    }
}
