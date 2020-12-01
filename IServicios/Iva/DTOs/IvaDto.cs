using IServicios.BaseDto;

namespace IServicios.Iva.DTOs
{
    public class IvaDto : DtoBase
    {
        public string Descripcion { get; set; }

        public decimal Porcentaje { get; set; }
    }
}