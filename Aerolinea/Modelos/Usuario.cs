using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Codigo es obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Clave es obligatorio")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "El Rol es obligatorio")]
        public string Rol { get; set; }
        public bool EstaActivo { get; set; }
    }
}
