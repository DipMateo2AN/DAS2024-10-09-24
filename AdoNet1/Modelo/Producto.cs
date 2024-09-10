namespace Modelo
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public int CantidadActual { get; set; }

        public int CantidadMinima { get; set; }

        public Categoria Categoria { get; set; }
    }
}
