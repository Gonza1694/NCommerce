using Dominio.UnidadDeTrabajo;
using IServicios.BaseDto;
using IServicios.Deposito;
using IServicios.Deposito.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.Deposito
{
    public class DepositoServicio : IDepositoSevicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public DepositoServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Eliminar(long id)
        {
            _unidadDeTrabajo.DepositoRepositorio.Eliminar(id);
            _unidadDeTrabajo.Commit();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            var dto = (DepositoDto)dtoEntidad;

            var entidad = new Dominio.Entidades.Deposito
            {
                Descripcion = dto.Descripcion,
                Ubicacion = dto.Ubicacion,
                EstaEliminado = false
            };

            _unidadDeTrabajo.DepositoRepositorio.Insertar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            var dto = (DepositoDto)dtoEntidad;

            var entidad = _unidadDeTrabajo.DepositoRepositorio.Obtener(dto.Id);

            if (entidad == null) throw new Exception("Ocurrio un Error al Obtener el Deposito");

            entidad.Descripcion = dto.Descripcion;
            entidad.Ubicacion = dto.Ubicacion;

            _unidadDeTrabajo.DepositoRepositorio.Modificar(entidad);
            _unidadDeTrabajo.Commit();
        }

        public DtoBase Obtener(long id)
        {
            var entidad = _unidadDeTrabajo.DepositoRepositorio.Obtener(id);

            return new DepositoDto
            {
                Id = entidad.Id,
                Descripcion = entidad.Descripcion,
                Ubicacion = entidad.Ubicacion,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            Expression<Func<Dominio.Entidades.Deposito, bool>> filtro =
                x => x.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.DepositoRepositorio.Obtener(filtro)
                .Select(x => new DepositoDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Ubicacion = x.Ubicacion,
                    Eliminado = x.EstaEliminado
                })
                .OrderBy(x => x.Descripcion)
                .ToList();
        }

        public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
        {
            return entidadId.HasValue
                ? _unidadDeTrabajo.DepositoRepositorio.Obtener(x => !x.EstaEliminado
                                                                        && x.Id != entidadId.Value
                                                                        && x.Descripcion.Equals(datoVerificar,
                                                                            StringComparison.CurrentCultureIgnoreCase))
                    .Any()
                : _unidadDeTrabajo.DepositoRepositorio.Obtener(x => !x.EstaEliminado
                                                                        && x.Descripcion.Equals(datoVerificar,
                                                                            StringComparison.CurrentCultureIgnoreCase))
                    .Any();
        }
    }
}