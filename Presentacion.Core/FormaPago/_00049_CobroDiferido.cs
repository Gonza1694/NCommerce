using PresentacionBase.Formularios;
using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace Presentacion.Core.FormaPago
{
    public partial class _00049_CobroDiferido : FormBase
    {
        public _00049_CobroDiferido()
        {
            InitializeComponent();

            // Libreria para que refresque cada 60 seg la grilla
            // con las facturas que estan pendientes de pago.
            Observable.Interval(TimeSpan.FromSeconds(60))
                .ObserveOn(DispatcherScheduler.Current)
                .Subscribe(_ =>
                {
                    // Aqui se debe poner la consulta y asignarla a la grilla
                });
        }
    }
}