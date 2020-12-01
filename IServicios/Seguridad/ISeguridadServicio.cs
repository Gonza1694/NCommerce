using IServicios.Usuario.DTOs;

namespace IServicios.Seguridad
{
    public interface ISeguridadServicio
    {
        bool VerificarAcceso(string usuario, string password);

        UsuarioDto ObtenerUsuarioLogin(string nombreUsuario);
    }
}