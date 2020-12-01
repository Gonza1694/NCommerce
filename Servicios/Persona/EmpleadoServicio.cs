using Dominio.UnidadDeTrabajo;
using IServicios.Persona;
using System.Linq;

namespace Servicios.Persona
{
    public class EmpleadoServicio : PersonaServicio, IEmpleadoServicio
    {
        public EmpleadoServicio(IUnidadDeTrabajo unidadDeTrabajo)
            : base(unidadDeTrabajo)
        {
        }

        public int ObtenerSiguienteLegajo()
        {
            var empleados = _unidadDeTrabajo.EmpleadoRepositorio.Obtener();

            return empleados.Any()
                ? empleados.Max(x => x.Legajo) + 1
                : 1;
        }
    }
}