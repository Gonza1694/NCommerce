using Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Movimiento_CuentaCorrienteProveedor")]
    [MetadataType(typeof(IMovimientoCuentaCorrienteProveedor))]
    public class MovimientoCuentaCorrienteProveedor : Movimiento
    {
        // Propiedades

        public long ProveedorId { get; set; }

        // Propiedades de Navegacion
        public virtual Proveedor Proveedor { get; set; }
    }
}