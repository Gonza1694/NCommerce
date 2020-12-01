using Aplicacion.Constantes;
using Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Configuracion")]
    [MetadataType(typeof(IConfiguracion))]
    public class Configuracion : EntidadBase
    {
        // ====================================== //
        // ====    Datos de la Empresa     ====== //
        // ====================================== //
        public string RazonSocial { get; set; }

        public string NombreFantasia { get; set; }

        public string Cuit { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public long LocalidadId { get; set; }

        // ====================================== //
        // ==   Datos del Stock y Articulo     == //
        // ====================================== //

        public bool FacturaDescuentaStock { get; set; }

        public bool PresupuestoDescuentaStock { get; set; }

        public bool RemitoDescuentaStock { get; set; }

        public bool ActualizaCostoDesdeCompra { get; set; }

        public bool ModificaPrecioVentaDesdeCompra { get; set; }

        public long DepositoStockId { get; set; }

        public long DepositoVentaId { get; set; }

        // ====================================== //
        // ==         Venta por defecto         == //
        // ====================================== //

        public TipoPago TipoFormaPagoPorDefectoVenta { get; set; }

        public TipoPago TipoFormaPagoPorDefectoCompra { get; set; }

        // ====================================== //
        // =========    Comprobante     ========= //
        // ====================================== //

        public string ObservacionEnPieFactura { get; set; }

        public bool UnificarRenglonesIngresarMismoProducto { get; set; }

        public long ListaPrecioPorDefectoId { get; set; }

        // ====================================== //
        // =========         Caja       ========= //
        // ====================================== //

        public bool IngresoManualCajaInicial { get; set; }

        public bool PuestoCajaSeparado { get; set; }

        public bool ActivarRetiroDeCaja { get; set; }

        // Propiedad para no permitir que tenga mas de un cierto
        // monto de dinero en la caja
        public decimal MontoMaximoRetiroCaja { get; set; }

        // ====================================== //
        // =========         Bascula    ========= //
        // ====================================== //

        public bool ActivarBascula { get; set; }
        public string CodigoBascula { get; set; }
        public bool EsImpresionPorPrecio { get; set; }

        // Propiedades de Navegacion
        public virtual ListaPrecio ListaPrecioPorDefecto { get; set; }

        public virtual Localidad Localidad { get; set; }

        public virtual Deposito DepositoStock { get; set; }

        public virtual Deposito DepositoVenta { get; set; }
    }
}