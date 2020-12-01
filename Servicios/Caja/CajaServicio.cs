using Dominio.UnidadDeTrabajo;
using IServicios.Caja;
using IServicios.Caja.DTOs;
using Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Servicios.Caja
{
    public class CajaServicio : ICajaServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public CajaServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public bool VerificarSiEstaAbierta(long usuarioId)
        {
            return _unidadDeTrabajo.CajaRepositorio.Obtener(x => x.UsuarioAperturaId == usuarioId
                                                                 && x.UsuarioCierreId == null).Any();
        }

        public decimal ObtenerUltimoMontoDeCierre(long usuarioId)
        {
            var cajasAnteriores = _unidadDeTrabajo.CajaRepositorio.
                Obtener(x => x.UsuarioAperturaId == usuarioId && x.UsuarioCierreId != null);

            if (cajasAnteriores.Any())
            {
                //obtener la ultima caja

                var ultimaCaja = cajasAnteriores
                    .Where(x => x.FechaCierre.Value == cajasAnteriores.Max(f => f.FechaCierre.Value))
                    .LastOrDefault();

                if (ultimaCaja == null)
                {
                    return 0m;
                }
                else
                {
                    return ultimaCaja.MontoCierre.Value;
                }
            }

            return 0m;
        }

        public void Abrir(long usuarioId, decimal monto)
        {
            try
            {
                var cajaNueva = new Dominio.Entidades.Caja
                {
                    UsuarioAperturaId = usuarioId,
                    FechaApertura = DateTime.Now,
                    MontoInicial = monto,
                    //----------//
                    UsuarioCierreId = (long?)null,
                    FechaCierre = (DateTime?)null,
                    MontoCierre = (decimal?)null,
                    //----------//
                    TotalEntradaCheque = 0,
                    TotalEntradaEfectivo = 0,
                    TotalEntradaCtaCte = 0,
                    TotalEntradaTarjeta = 0,
                    TotalSalidaCheque = 0,
                    TotalSalidaCtaCte = 0,
                    TotalSalidaEfectivo = 0,
                    TotalSalidaTarjeta = 0,
                    EstaEliminado = false,
                };
                _unidadDeTrabajo.CajaRepositorio.Insertar(cajaNueva);

                _unidadDeTrabajo.Commit();
            }
            catch
            {
                throw new Exception("Ocurrio un error al abrir la caja!");
            }
        }

        public IEnumerable<CajaDto> Obtener(bool ActivarRango, DateTime fechaDesde, DateTime fechaHasta, string cadenaBuscar)
        {
            Expression<Func<Dominio.Entidades.Caja, bool>> filtro = x => x.UsuarioApertura.Nombre.Contains(cadenaBuscar)
                || x.UsuarioCierre.Nombre.Contains(cadenaBuscar);

            var _fechaDesde = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day, 0, 0, 0);

            var _fechaHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day, 23, 59, 59);

            if (ActivarRango)
            {
                filtro = filtro.And(x => x.FechaApertura >= _fechaDesde && x.FechaApertura <= _fechaHasta);
            }
            return _unidadDeTrabajo.CajaRepositorio.Obtener(filtro, "UsuarioApertura, UsuarioCierre")
                .Select(x => new CajaDto
                {
                    Id = x.Id,
                    UsuarioAperturaId = x.UsuarioAperturaId,
                    UsuarioApertura = x.UsuarioApertura.Nombre,
                    FechaApertura = x.FechaApertura,
                    MontoApertura = x.MontoInicial,
                    //----------//
                    UsuarioCierreId = x.UsuarioCierreId,
                    UsuarioCierre = x.UsuarioCierreId.HasValue? x.UsuarioCierre.Nombre:"-----",
                    FechaCierre = x.FechaCierre,
                    MontoCierre = x.MontoCierre,
                    //----------//
                    TotalEntradaCheque = x.TotalEntradaCheque,
                    TotalEntradaCtaCte = x.TotalEntradaCtaCte,
                    TotalEntradaEfectivo = x.TotalEntradaEfectivo,
                    TotalEntradaTarjeta = x.TotalEntradaTarjeta,
                    //----------//
                    TotalSalidaCheque =x.TotalSalidaCheque,
                    TotalSalidaCtaCte = x.TotalSalidaCtaCte,
                    TotalSalidaEfectivo = x.TotalSalidaEfectivo,
                    TotalSalidaTarjeta = x.TotalSalidaTarjeta,

                    Eliminado = x.EstaEliminado
                    
                }).ToList();
        }
    }
}