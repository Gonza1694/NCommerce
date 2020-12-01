using Dominio.UnidadDeTrabajo;
using IServicios.BaseDto;
using IServicios.Comprobante;
using IServicios.Tarjeta.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.Comprobante
{
    public class TarjetaServicio : ComprobanteServicio, ITarjetaServicio
    {
        public TarjetaServicio(IUnidadDeTrabajo unidadDeTrabajo) : base(unidadDeTrabajo)
        {
        }

        public void Eliminar(long id)
        {
            _unidadDeTrabajo.TarjetaRepositorio.Eliminar(id);
            _unidadDeTrabajo.Commit();
        }

        //TODO
        public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
        {
            return entidadId.HasValue
                ? _unidadDeTrabajo.TarjetaRepositorio.Obtener(x => !x.EstaEliminado
                                                                   && x.Id != entidadId.Value
                                                                   && x.Descripcion.Equals(datoVerificar,
                                                                       StringComparison.CurrentCultureIgnoreCase))
                    .Any()
                : _unidadDeTrabajo.TarjetaRepositorio.Obtener(x => !x.EstaEliminado
                                                                   && x.Descripcion.Equals(datoVerificar,
                                                                       StringComparison.CurrentCultureIgnoreCase))
                    .Any();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            var dto = (TarjetaDto)dtoEntidad;

            var entidad = new Dominio.Entidades.Tarjeta
            {
                Descripcion = dto.Descripcion,
                EstaEliminado = false
            };

            _unidadDeTrabajo.TarjetaRepositorio.Insertar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            var dto = (TarjetaDto)dtoEntidad;

            var entidad = _unidadDeTrabajo.TarjetaRepositorio.Obtener(dto.Id);

            if (entidad == null) throw new Exception("Ocurrio un error al obtener el Tarjeta");

            entidad.Descripcion = dto.Descripcion;

            _unidadDeTrabajo.TarjetaRepositorio.Modificar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public DtoBase Obtener(long id)
        {
            var entidad = _unidadDeTrabajo.TarjetaRepositorio.Obtener(id);

            return new TarjetaDto
            {
                Id = entidad.Id,
                Descripcion = entidad.Descripcion,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            Expression<Func<Dominio.Entidades.Tarjeta, bool>> filtro =
                x => x.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.TarjetaRepositorio.Obtener(filtro)
                .Select(x => new TarjetaDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.EstaEliminado
                })
                .OrderBy(x => x.Descripcion)
                .ToList();
        }
    }
}