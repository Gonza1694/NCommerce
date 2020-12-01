namespace IServicios.Comprobante
{
    public interface ITarjetaServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}