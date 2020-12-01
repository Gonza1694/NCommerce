namespace IServicios.Departamento
{
    public interface ICondicionIvaServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}