using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.info.Blazor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Rol es obligatorio")]
        public int IdRol { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Correo es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "La Contraseña es obligatoria")]
        public string Contraseña { get; set; }

    }
}
