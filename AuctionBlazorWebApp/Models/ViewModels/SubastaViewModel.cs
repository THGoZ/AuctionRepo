using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class SubastaViewModel
    {
        public int IdSubasta { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCierre { get; set; }
        public string[] ModoEntrega { get; set; } = null!;
        public string[] FormaDePago { get; set; } = null!;
        public bool? Estado { get; set; }//Activa = true /-Finalizada = false, null = proxima
        public string Descripcion { get; set; } = null!;
        public int CantidadDeOfertas { get; set; }
    }
}
