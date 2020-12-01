namespace Presentacion.Core.Comprobantes.Clases
{
    public class ItemView
    {
        public long Id { get; set; }
        public long ArticuloId { get; set; }

        public long ListaPrecioId { get; set; }

        public bool EsArticuloAlternativo { get; set; } = false;

        public bool IngresoPorBascula { get; set; } = false;

        public string CodigoBarra { get; set; }

        public string Descripcion { get; set; }

        public decimal Iva { get; set; }

        public decimal Precio { get; set; }

        public string PrecioStr => Precio.ToString("C");

        public decimal Cantidad { get; set; }

        // Propiedad (Campo) Calculado
        public decimal SubTotal => Precio * Cantidad;

        public string SubTotalStr => SubTotal.ToString("C");
    }
}