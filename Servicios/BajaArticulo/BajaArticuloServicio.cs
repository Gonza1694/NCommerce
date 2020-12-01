using Dominio.UnidadDeTrabajo;
using IServicios.BajaArticulo;
using IServicios.BaseDto;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.BajaArticulo
{
    public class BajaArticuloServicio : IBajaArticuloServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public BajaArticuloServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Eliminar(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Insertar(DtoBase dtoEntidad)
        {
            throw new System.NotImplementedException();
        }

        public void Modificar(DtoBase dtoEntidad)
        {
            throw new System.NotImplementedException();
        }

        public DtoBase Obtener(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DtoBase> Obtener(string cadenaBuscar, bool mostrarTodos = true)
        {
            var codigo = -1;

            int.TryParse(cadenaBuscar, out codigo);

            Expression<Func<Dominio.Entidades.BajaArticulo, bool>> filtro = x =>
                x.Articulo.Descripcion.Contains(cadenaBuscar)
                || x.Articulo.Codigo == codigo
                || x.Articulo.CodigoBarra == cadenaBuscar
                || x.MotivoBaja.Descripcion.Contains(cadenaBuscar);

            if (!mostrarTodos)
            {
                filtro = filtro.And(x => !x.EstaEliminado);
            }

            return _unidadDeTrabajo.BajaArticuloRepositorio.Obtener(filtro
                    , "Articulo, MotivoBaja")
                .Select(x => new BajaArticuloDtos()
                {
                    Id = x.Id,
                    ArticuloId = x.ArticuloId,
                    Articulo = x.Articulo.Descripcion,
                    MotivoBajaId = x.MotivoBajaId,
                    MotivoBaja = x.MotivoBaja.Descripcion,
                    Cantidad = x.Cantidad,
                    Eliminado = x.EstaEliminado,
                    Fecha = x.Fecha,
                    Observacion = x.Observacion
                }).ToList();
        }
    }
}