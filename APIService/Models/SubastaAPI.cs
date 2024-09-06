using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIService.Models
{
    public class SubastaAPI
    {
        public int IdSubasta { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public string[] ModoEntrega { get; set; }
        public string[] FormaDePago { get; set; }
        public bool? Estado { get; set; }//Activa = true /-Finalizada = false, null = proxima
        public string Descripcion { get; set; }
    }
}
