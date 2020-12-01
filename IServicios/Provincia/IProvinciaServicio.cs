namespace IServicios.Provincia
{
    public interface IProvinciaServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}