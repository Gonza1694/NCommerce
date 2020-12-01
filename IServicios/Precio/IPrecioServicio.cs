namespace IServicios.Precio
{
    public interface IPrecioServicio
    {
        void ActualizarPrecio(decimal valor, bool esPorcentaje, long? marcaId = null, long? rubroId = null,
            long? listaPrecioId = null, int? codigoDesde = null, int? codigoHasta = null);
    }
}