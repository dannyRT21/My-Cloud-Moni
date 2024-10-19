using System.ComponentModel.DataAnnotations;

namespace cloud_moni.models
{
    public class Usuarios
       
    {   
        [Key]
        //public int Id { get; set; }

        public int idUsuario { get; set; }
        public int usuario { get; set; }
        public int clave { get; set; }
        public int nombre { get; set; }
        public int direccion { get; set; }
        public int telefono { get; set; }
    }
}
