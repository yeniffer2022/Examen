using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Aerolinea
    {

        [Required (ErrorMessage = "El IdVuelo es obligatorio")] 
        public string IdVuelo { get; set; }
        [Required(ErrorMessage = "El Origen es obligatorio")]
        public string Origen { get; set; }
        [Required(ErrorMessage = "El Destino es obligatorio")]
        public string  Destino { get; set; }
        [Required(ErrorMessage = "El Nombre del avion es obligatorio")]
        public string Avion { get; set; }
        [Required(ErrorMessage = "El Cantidad es obligatoria")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El Nombre del piloto es obligatorio")]
        public string Piloto { get; set; }
        [Required(ErrorMessage = "La Fecha es obligatoria")]
        public DateTime Fecha { get; set; }

    }
}
