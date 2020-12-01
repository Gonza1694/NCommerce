using Aplicacion.Constantes;
using Dominio.UnidadDeTrabajo;
using IServicios.Contador;
using System;
using System.Linq;

namespace Servicios.Contador
{
    public class ContadorServicio : IContadorServicio
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public ContadorServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public int ObtenerSiguienteNumeroComprobante(TipoComprobante tipoComprobante)
        {
            // Obtengo el Valor
            var resultado = _unidadDeTrabajo.ContadorRepositorio
                .Obtener(x => x.TipoComprobante == tipoComprobante).FirstOrDefault();

            if (resultado == null)
            {
                throw new Exception("Ocurrio un error al Obtener el numero de comprobante");
            }

            // Incremento
            resultado.Valor++;

            // Actualizo asi Otra ventana obtenga el valor actualizado
            _unidadDeTrabajo.ContadorRepositorio.Modificar(resultado);

            // retorno el Valor
            return resultado.Valor;
        }
    }
}