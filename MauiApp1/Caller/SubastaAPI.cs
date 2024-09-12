using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Caller
{
    public class SubastaAPI
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
        public int CantidadProductos { get; set; }
    }
}