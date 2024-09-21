public class ProductoWinner
{
    public int IdSubasta { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal PrecioBase { get; set; }
    public string ImageExtension { get; set; }
    public byte[] Imagen { get; set; }
    public bool HasGanador { get; set; }
    public string NombreGanador { get; set; }
    public string ApellidoGanador { get; set; }
    public decimal Monto { get; set; }
    public int TotalDeOfertas { get; set; }
    public ImageSource Image { get; set; }
}
