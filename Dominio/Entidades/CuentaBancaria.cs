using Dominio.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("CuentaBancarias")]
    [MetadataType(typeof(ICuentaBancaria))]
    public class CuentaBancaria : EntidadBase
    {
        // Propiedades
        public long BancoId { get; set; }

        public string Numero { get; set; }

        public string Titular { get; set; }

        // Propiedades de Navegacion
        public virtual Banco Banco { get; set; }

        public virtual ICollection<DepositoCheque> DepositoCheques { get; set; }
    }
}