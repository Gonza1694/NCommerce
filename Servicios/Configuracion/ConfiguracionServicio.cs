using Dominio.UnidadDeTrabajo;
using IServicios.Configuracion;
using IServicios.Configuracion.DTOs;
using System.Linq;

namespace Servicios.Configuracion
{
    public class ConfiguracionServicio : IConfiguracionServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public ConfiguracionServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Grabar(ConfiguracionDto configuracionDto)
        {
            var config = configuracionDto.EsPrimeraVez
                ? new Dominio.Entidades.Configuracion()
                : _unidadDeTrabajo.ConfiguracionRepositorio.Obtener(configuracionDto.Id);

            config.Id = configuracionDto.Id;
            config.EstaEliminado = false;
            config.LocalidadId = configuracionDto.LocalidadId;
            config.ActivarRetiroDeCaja = configuracionDto.ActivarRetiroDeCaja;
            config.ActualizaCostoDesdeCompra = configuracionDto.ActualizaCostoDesdeCompra;
            config.Celular = configuracionDto.Celular;
            config.Cuit = configuracionDto.Cuit;
            config.Direccion = configuracionDto.Direccion;
            config.Email = configuracionDto.Email;
            config.FacturaDescuentaStock = configuracionDto.FacturaDescuentaStock;
            config.IngresoManualCajaInicial = configuracionDto.IngresoManualCajaInicial;
            config.ListaPrecioPorDefectoId = configuracionDto.ListaPrecioPorDefectoId;
            config.ModificaPrecioVentaDesdeCompra = configuracionDto.ModificaPrecioVentaDesdeCompra;
            config.MontoMaximoRetiroCaja = configuracionDto.MontoMaximoRetiroCaja;
            config.NombreFantasia = configuracionDto.NombreFantasia;
            config.ObservacionEnPieFactura = configuracionDto.ObservacionEnPieFactura;
            config.PresupuestoDescuentaStock = configuracionDto.PresupuestoDescuentaStock;
            config.PuestoCajaSeparado = configuracionDto.PuestoCajaSeparado;
            config.RazonSocial = configuracionDto.RazonSocial;
            config.RemitoDescuentaStock = configuracionDto.RemitoDescuentaStock;
            config.Telefono = configuracionDto.Telefono;
            config.TipoFormaPagoPorDefectoCompra = configuracionDto.TipoFormaPagoPorDefectoCompra;
            config.TipoFormaPagoPorDefectoVenta = configuracionDto.TipoFormaPagoPorDefectoVenta;
            config.UnificarRenglonesIngresarMismoProducto = configuracionDto.UnificarRenglonesIngresarMismoProducto;
            config.DepositoStockId = configuracionDto.DepositoStockId;
            config.DepositoVentaId = configuracionDto.DepositoVentaId;
            config.ActivarBascula = configuracionDto.ActivarBascula;
            config.CodigoBascula = configuracionDto.CodigoBascula;
            config.EsImpresionPorPrecio = configuracionDto.EsImpresionPorPrecio;

            if (configuracionDto.EsPrimeraVez)
            {
                _unidadDeTrabajo.ConfiguracionRepositorio.Insertar(config);
            }
            else
            {
                _unidadDeTrabajo.ConfiguracionRepositorio.Modificar(config);
            }

            _unidadDeTrabajo.Commit();
        }

        public ConfiguracionDto Obtener()
        {
            var config = _unidadDeTrabajo.ConfiguracionRepositorio
                .Obtener(null, "DepositoStock, DepositoVenta, ListaPrecioPorDefecto, Localidad, Localidad.Departamento, Localidad.Departamento.Provincia")
                .FirstOrDefault();

            if (config == null) return null;

            return new ConfiguracionDto
            {
                Id = config.Id,
                Eliminado = false,
                LocalidadId = config.LocalidadId,
                DepartamentoId = config.Localidad.DepartamentoId,
                ProvinciaId = config.Localidad.Departamento.ProvinciaId,
                DepositoStockId = config.DepositoStockId,
                DepositoStock = config.DepositoStock.Descripcion,
                DepositoVentaId = config.DepositoVentaId,
                DepositoVenta = config.DepositoVenta.Descripcion,
                ActivarRetiroDeCaja = config.ActivarRetiroDeCaja,
                ActualizaCostoDesdeCompra = config.ActualizaCostoDesdeCompra,
                Celular = config.Celular,
                Cuit = config.Cuit,
                Direccion = config.Direccion,
                Email = config.Email,
                FacturaDescuentaStock = config.FacturaDescuentaStock,
                IngresoManualCajaInicial = config.IngresoManualCajaInicial,
                ListaPrecioPorDefectoId = config.ListaPrecioPorDefectoId,
                ModificaPrecioVentaDesdeCompra = config.ModificaPrecioVentaDesdeCompra,
                MontoMaximoRetiroCaja = config.MontoMaximoRetiroCaja,
                NombreFantasia = config.NombreFantasia,
                ObservacionEnPieFactura = config.ObservacionEnPieFactura,
                PresupuestoDescuentaStock = config.PresupuestoDescuentaStock,
                PuestoCajaSeparado = config.PuestoCajaSeparado,
                RazonSocial = config.RazonSocial,
                RemitoDescuentaStock = config.RemitoDescuentaStock,
                Telefono = config.Telefono,
                TipoFormaPagoPorDefectoCompra = config.TipoFormaPagoPorDefectoCompra,
                TipoFormaPagoPorDefectoVenta = config.TipoFormaPagoPorDefectoVenta,
                UnificarRenglonesIngresarMismoProducto = config.UnificarRenglonesIngresarMismoProducto,
                ActivarBascula = config.ActivarBascula,
                CodigoBascula = config.CodigoBascula,
                EsImpresionPorPrecio = config.EsImpresionPorPrecio,
            };
        }
    }
}