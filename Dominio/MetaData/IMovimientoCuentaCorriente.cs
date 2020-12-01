using System.ComponentModel.DataAnnotations;

namespace Dominio.MetaData
{
    public interface IMovimientoCuentaCorriente : IMovimiento
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long ClienteId { get; set; }
    }
}