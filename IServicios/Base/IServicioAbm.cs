using IServicios.BaseDto;

namespace IServicios.Base
{
    public interface IServiciosAbm
    {
        void Insertar(DtoBase dtoEntidad);

        void Modificar(DtoBase dtoEntidad);

        void Eliminar(long id);
    }
}