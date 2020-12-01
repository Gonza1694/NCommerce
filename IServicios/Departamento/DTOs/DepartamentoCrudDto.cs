using IServicios.BaseDto;

namespace IServicioss.Departamento.DTOs
{
    public class DepartamentoCrudDto : DtoBase
    {
        public long ProvinciaId { get; set; }
        public string Descripcion { get; set; }
    }
}