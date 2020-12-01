using Dominio.UnidadDeTrabajo;
using IServicios.BaseDto;
using IServicios.PuestoTrabajo;
using IServicioss.PuestoTrabajo.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.PuestoTrabajo
{
    public class PuestoTrabajoServicio : IPuestoTrabajoServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public PuestoTrabajoServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Eliminar(long id)
        {
            _unidadDeTrabajo.PuestoTrabajoRepositorio.Eliminar(id);
            _unidadDeTrabajo.Commit();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            var dto = (PuestoTrabajooDto)dtoEntidad;

            var entidad = new Dominio.Entidades.PuestoTrabajo
            {
                Descripcion = dto.Descripcion,
                Codigo = dto.Codigo,
                EstaEliminado = false
            };

            _unidadDeTrabajo.PuestoTrabajoRepositorio.Insertar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            var dto = (PuestoTrabajooDto)dtoEntidad;

            var entidad = _unidadDeTrabajo.PuestoTrabajoRepositorio.Obtener(dto.Id);

            if (entidad == null) throw new Exception("Ocurrió un Error al Obtener la PuestoTrabajo");

            entidad.Descripcion = dto.Descripcion;
            entidad.Codigo = dto.Codigo;

            _unidadDeTrabajo.PuestoTrabajoRepositorio.Modificar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public DtoBase Obtener(long id)
        {
            var entidad = _unidadDeTrabajo.PuestoTrabajoRepositorio.Obtener(id);

            return new PuestoTrabajooDto
            {
                Id = entidad.Id,
                Codigo = entidad.Codigo,
                Descripcion = entidad.Descripcion,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            Expression<Func<Dominio.Entidades.PuestoTrabajo, bool>> filtro = x =>
                x.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.PuestoTrabajoRepositorio.Obtener(filtro)
                .Select(x => new PuestoTrabajooDto
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    Descripcion = x.Descripcion,
                    Eliminado = x.EstaEliminado
                })
                .OrderBy(x => x.Descripcion)
                .ToList();
        }

        public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
        {
            return entidadId.HasValue
                ? _unidadDeTrabajo.PuestoTrabajoRepositorio.Obtener(x => !x.EstaEliminado
                                                                         && x.Id != entidadId.Value
                                                                         && x.Descripcion.Equals(datoVerificar,
                                                                             StringComparison.CurrentCultureIgnoreCase))
                    .Any()
                : _unidadDeTrabajo.PuestoTrabajoRepositorio.Obtener(x => !x.EstaEliminado
                                                                         && x.Descripcion.Equals(datoVerificar,
                                                                             StringComparison.CurrentCultureIgnoreCase))
                    .Any();
        }
    }
}