using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;


namespace Aplicacion.Constantes
{
    public class InstanciarDentroFormulario
    {
        public virtual void InstanciarFormDentro<Formulario>(object sender) where Formulario : Form {

            var formu = CrearFormu<Formulario>();

            InstanciarFormu(formu);

        }
        private void InstanciarFormu<Formulario>(Formulario formu) where Formulario : Form
        {
            if (formu == null)
            {
                formu = ObjectFactory.GetInstance<Formulario>();
                formu.TopLevel = false;
                flp_contenedor.Controls.Add(formu);
                formu.Dock = DockStyle.Fill;
                formu.Show();
                formu.BringToFront();
            }
            else
            {
                formu.BringToFront();
            }
        }

        private Formulario CrearFormu<Formulario>() where Formulario : Form
        {
            var formu = flp_contenedor.Controls.OfType<Formulario>().FirstOrDefault();
            return formu;
        }
    }
}
