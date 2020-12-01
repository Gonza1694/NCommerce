namespace IServicios.ListaPrecio
{
    public interface IListaPrecioServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
    }
}