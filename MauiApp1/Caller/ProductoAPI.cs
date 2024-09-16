namespace AuctionMobileApp.Caller
{
    public class ProductoAPI
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool? EstadoDeSolicitud { get; set; }//null = pendiente/ false = rechazado / true = aprovado

        public int? IdSubasta { get; set; }

        public int IdUsuario { get; set; }
        public int CantidadDeOfertas { get; set; }

        public ImageSource Image { get; set; }
    }
}