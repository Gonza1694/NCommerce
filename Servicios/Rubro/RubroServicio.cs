using Dominio.UnidadDeTrabajo;
using IServicios.BaseDto;
using IServicios.Rubro;
using IServicios.Rubro.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.Rubro
{
    public class RubroServicio : IRubroServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public RubroServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Eliminar(long id)
        {
            _unidadDeTrabajo.RubroRepositorio.Eliminar(id);
            _unidadDeTrabajo.Commit();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            var dto = (RubroDto)dtoEntidad;

            var entidad = new Dominio.Entidades.Rubro
            {
                Descripcion = dto.Descripcion,
                EstaEliminado = false
            };

            _unidadDeTrabajo.RubroRepositorio.Insertar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            var dto = (RubroDto)dtoEntidad;

            var entidad = _unidadDeTrabajo.RubroRepositorio.Obtener(dto.Id);

            if (entidad == null) throw new Exception("Ocurrió un error al obtener el Rubro");

            entidad.Descripcion = dto.Descripcion;

            _unidadDeTrabajo.RubroRepositorio.Modificar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public DtoBase Obtener(long id)
        {
            var entidad = _unidadDeTrabajo.RubroRepositorio.Obtener(id);

            return new RubroDto
            {
                Id = entidad.Id,
                Descripcion = entidad.Descripcion,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            Expression<Func<Dominio.Entidades.Rubro, bool>> filtro =
                x => x.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.RubroRepositorio.Obtener(filtro)
                .Select(x => new RubroDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.EstaEliminado
                })
                .OrderBy(x => x.Descripcion)
                .ToList();
        }

        public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
        {
            return entidadId.HasValue
                ? _unidadDeTrabajo.RubroRepositorio.Obtener(x => !x.EstaEliminado
                                                                     && x.Id != entidadId.Value
                                                                     && x.Descripcion.Equals(datoVerificar,
                                                                         StringComparison.CurrentCultureIgnoreCase))
                    .Any()
                : _unidadDeTrabajo.RubroRepositorio.Obtener(x => !x.EstaEliminado
                                                                 && x.Descripcion.Equals(datoVerificar,
                                                                     StringComparison.CurrentCultureIgnoreCase))
                    .Any();
        }
    }
}