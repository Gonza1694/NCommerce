using Dominio.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Rubro")]
    [MetadataType(typeof(IRubro))]
    public class Rubro : EntidadBase
    {
        // Propiedades
        public string Descripcion { get; set; }

        // Propiedades de Navegacion
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}