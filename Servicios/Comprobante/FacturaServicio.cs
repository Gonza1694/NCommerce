using Dominio.UnidadDeTrabajo;
using IServicios.Comprobante;
namespace Servicios.Comprobante
{
    public class FacturaServicio : ComprobanteServicio, IFacturaServicio
    {
        public FacturaServicio(IUnidadDeTrabajo unidadDeTrabajo)
            : base(unidadDeTrabajo)
        {
        }
    }
}