using IServicios.Localidad.DTOs;
using System.Collections.Generic;

namespace IServicios.Localidad
{
    public interface ILocalidadServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long idRelacional, long? entidadId = null);

        IEnumerable<LocalidadDto> ObtenerPorDepartamento(long departamentoId);
    }
}