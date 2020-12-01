namespace IServicios.Comprobante
{
    public interface IBancoServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}