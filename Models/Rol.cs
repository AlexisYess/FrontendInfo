using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.info.Blazor.Models
{
    public class Rol
    {
        public  int Id { get; set; }
        [Required(ErrorMessage="Nombre es Obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Descripcion es Obligatoria")]
        public string Descripcion { get; set; }
    }
}
