using IServicios.BaseDto;

namespace IServicioss.Localidad.DTOs
{
    public class LocalidadCrudDto : DtoBase
    {
        public long DepartamentoId { get; set; }
        public string Descripcion { get; set; }
    }
}