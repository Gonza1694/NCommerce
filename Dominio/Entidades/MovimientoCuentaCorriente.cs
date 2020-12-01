using Aplicacion.Constantes;
using Dominio.MetaData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Movimiento_CuentaCorriente")]
    [MetadataType(typeof(IMovimientoCuentaCorriente))]
    public class MovimientoCuentaCorriente : Movimiento
    {
        // Propiedades
        public long ClienteId { get; set; }


        // Propiedades de Navegacion
        public virtual Cliente Cliente { get; set; }
    }
}