namespace IServicios.PuestoTrabajo
{
    public interface IPuestoTrabajoServicio : IServicios.Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}