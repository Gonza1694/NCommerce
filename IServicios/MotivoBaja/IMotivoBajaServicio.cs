namespace IServicios.MotivoBaja
{
    public interface IMotivoBajaServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}