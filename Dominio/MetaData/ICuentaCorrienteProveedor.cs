using Aplicacion.Constantes;
using System.ComponentModel.DataAnnotations;

namespace Dominio.MetaData
{
    public interface ICuentaCorrienteProveedor : IComprobante
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        Estado Estado { get; set; }
    }
}