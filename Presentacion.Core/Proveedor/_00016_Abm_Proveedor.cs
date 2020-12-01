using PresentacionBase.Formularios;

namespace Presentacion.Core.Proveedor
{
    public partial class _00016_Abm_Proveedor : FormAbm
    {
        public _00016_Abm_Proveedor(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
        }
    }
}