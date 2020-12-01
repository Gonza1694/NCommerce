using IServicios.Configuracion.DTOs;

namespace IServicios.Configuracion
{
    public interface IConfiguracionServicio
    {
        void Grabar(ConfiguracionDto configuracionDto);

        ConfiguracionDto Obtener();
    }
}