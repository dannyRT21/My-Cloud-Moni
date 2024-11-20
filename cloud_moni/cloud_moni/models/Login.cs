using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cloud_moni.models
{
    public class Login

    {
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
    }
}
