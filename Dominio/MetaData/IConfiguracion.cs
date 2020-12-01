using Aplicacion.Constantes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.MetaData
{
    public interface IConfiguracion
    {
        // ====================================== //
        // ====    Datos de la Empresa     ====== //
        // ====================================== //

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string RazonSocial { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string NombreFantasia { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(13, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Cuit { get; set; }

        [StringLength(25, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Telefono { get; set; }

        [StringLength(25, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Celular { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(400, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Direccion { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        long LocalidadId { get; set; }

        // ====================================== //
        // ==   Datos del Stock y Articulo     == //
        // ====================================== //

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(true)]
        bool FacturaDescuentaStock { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(false)]
        bool PresupuestoDescuentaStock { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(false)]
        bool RemitoDescuentaStock { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(true)]
        bool ActualizaCostoDesdeCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(true)]
        bool ModificaPrecioVentaDesdeCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        long DepositoStockId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        long DepositoVentaId { get; set; }

        // ====================================== //
        // ==    Forma de Pago por defecto     == //
        // ====================================== //

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [EnumDataType(typeof(TipoPago))]
        TipoPago TipoFormaPagoPorDefectoVenta { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [EnumDataType(typeof(TipoPago))]
        TipoPago TipoFormaPagoPorDefectoCompra { get; set; }

        // ====================================== //
        // =========    Comprobante     ========= //
        // ====================================== //

        [StringLength(400, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string ObservacionEnPieFactura { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(true)]
        bool UnificarRenglonesIngresarMismoProducto { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        long ListaPrecioPorDefectoId { get; set; }

        // ====================================== //
        // =========         Caja       ========= //
        // ====================================== //

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(true)]
        bool IngresoManualCajaInicial { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(false)]
        bool PuestoCajaSeparado { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DefaultValue(false)]
        bool ActivarRetiroDeCaja { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [DataType(DataType.Currency)]
        // Propiedad para no permitir que tenga mas de un cierto
        // monto de dinero en la caja
        decimal MontoMaximoRetiroCaja { get; set; }

        // ====================================== //
        // =========         Bascula    ========= //
        // ====================================== //

        [DefaultValue(false)]
        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        bool ActivarBascula { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(4, ErrorMessage = "El campo {0} debe ser menor a 4 Digitos")]
        [MinLength(4, ErrorMessage = "El campo {0} debe tener 4 Digitos")]
        string CodigoBascula { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        bool EsImpresionPorPrecio { get; set; }
    }
}