using Dominio.UnidadDeTrabajo;
using IServicios.BaseDto;
using IServicios.ListaPrecio;
using IServicios.ListaPrecio.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.ListaPrecio
{
    public class ListaPrecioServicio : IListaPrecioServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public ListaPrecioServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Eliminar(long id)
        {
            _unidadDeTrabajo.ListaPrecioRepositorio.Eliminar(id);
            _unidadDeTrabajo.Commit();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            var dto = (ListaPrecioDto)dtoEntidad;

            var entidad = new Dominio.Entidades.ListaPrecio
            {
                Descripcion = dto.Descripcion,
                NecesitaAutorizacion = dto.NecesitaAutorizacion,
                PorcentajeGanancia = dto.PorcentajeGanancia,
                EstaEliminado = false
            };

            _unidadDeTrabajo.ListaPrecioRepositorio.Insertar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            var dto = (ListaPrecioDto)dtoEntidad;

            var entidad = _unidadDeTrabajo.ListaPrecioRepositorio.Obtener(dto.Id);

            if (entidad == null) throw new Exception("Ocurrio un Error al Obtener la ListaPrecio");

            entidad.Descripcion = dto.Descripcion;
            entidad.PorcentajeGanancia = dto.PorcentajeGanancia;
            entidad.NecesitaAutorizacion = dto.NecesitaAutorizacion;

            _unidadDeTrabajo.ListaPrecioRepositorio.Modificar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public DtoBase Obtener(long id)
        {
            var entidad = _unidadDeTrabajo.ListaPrecioRepositorio.Obtener(id);

            return new ListaPrecioDto
            {
                Id = entidad.Id,
                Descripcion = entidad.Descripcion,
                NecesitaAutorizacion = entidad.NecesitaAutorizacion,
                PorcentajeGanancia = entidad.PorcentajeGanancia,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            Expression<Func<Dominio.Entidades.ListaPrecio, bool>> filtro =
                x => x.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.ListaPrecioRepositorio.Obtener(filtro)
                .Select(x => new ListaPrecioDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    NecesitaAutorizacion = x.NecesitaAutorizacion,
                    PorcentajeGanancia = x.PorcentajeGanancia,
                    Eliminado = x.EstaEliminado
                })
                .OrderBy(x => x.Descripcion)
                .ToList();
        }

        public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
        {
            return entidadId.HasValue
                ? _unidadDeTrabajo.ListaPrecioRepositorio.Obtener(x => !x.EstaEliminado
                                                                        && x.Id != entidadId.Value
                                                                        && x.Descripcion.Equals(datoVerificar,
                                                                            StringComparison.CurrentCultureIgnoreCase))
                    .Any()
                : _unidadDeTrabajo.ListaPrecioRepositorio.Obtener(x => !x.EstaEliminado
                                                                        && x.Descripcion.Equals(datoVerificar,
                                                                            StringComparison.CurrentCultureIgnoreCase))
                    .Any();
        }
    }
}