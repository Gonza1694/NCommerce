using IServicios.Articulo;
using IServicios.Articulo.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Core.Articulo
{
    public partial class ArticuloLookUp : FormLookUp
    {
        private readonly IArticuloServicio _articuloServicio;
        private long _listaPrecioId;
        public ArticuloDto ArticuloSeleccionado => (ArticuloDto)EntidadSeleccionada;

        public ArticuloLookUp(long listaPrecioId)
        {
            InitializeComponent();

            _articuloServicio = ObjectFactory.GetInstance<IArticuloServicio>();
            _listaPrecioId = listaPrecioId;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            dgv.DataSource = (List<ArticuloVentaDto>)_articuloServicio.ObtenerLookUp(cadenaBuscar, _listaPrecioId);

            base.ActualizarDatos(dgv, cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["CodigoBarra"].Visible = true;
            dgv.Columns["CodigoBarra"].Width = 100;
            dgv.Columns["CodigoBarra"].HeaderText = @"Codigo Barra";
            dgv.Columns["CodigoBarra"].DisplayIndex = 1;

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = @"Descripcion";
            dgv.Columns["Descripcion"].DisplayIndex = 2;

            dgv.Columns["Stock"].Visible = true;
            dgv.Columns["Stock"].Width = 100;
            dgv.Columns["Stock"].HeaderText = @"Stock";
            dgv.Columns["Stock"].DisplayIndex = 3;
            dgv.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["PrecioStr"].Visible = true;
            dgv.Columns["PrecioStr"].Width = 150;
            dgv.Columns["PrecioStr"].HeaderText = @"Precio Publico";
            dgv.Columns["PrecioStr"].DisplayIndex = 4;
            dgv.Columns["PrecioStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}