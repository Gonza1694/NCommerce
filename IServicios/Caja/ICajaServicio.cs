using System;
using System.Collections;
using System.Collections.Generic;
using IServicios.Caja.DTOs;

namespace IServicios.Caja
{
    public  interface ICajaServicio
    {
        bool VerificarSiEstaAbierta(long usuarioId);

        decimal ObtenerUltimoMontoDeCierre(long usuarioId);

        void Abrir(long usuarioId, decimal monto);

        IEnumerable<CajaDto> Obtener(bool ActivarRango, DateTime fechaDesde, DateTime fechaHasta, string cadenaBuscar);
    }
}