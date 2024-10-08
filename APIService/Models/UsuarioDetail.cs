using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIService.Models
{
    public class UsuarioDetail
    {
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Direccion { get; set; }
        [MaxLength(14)]
        public string? Cuil { get; set; }
    }
}
