using IServicios.Departamento.DTOs;
using System.Collections.Generic;

namespace IServicios.Departamento
{
    public interface IDepartamentoServicio : Base.IServicios
    {
        bool VerificarSiExiste(string datoVerificar, long idRelacional, long? entidadId = null);

        IEnumerable<DepartamentoDto> ObtenerPorProvincia(long provinciaId);
    }
}