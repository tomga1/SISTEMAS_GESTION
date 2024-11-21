using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAS_GESTION
{
    public partial class frmSubRubro : Form
    {
        private string modo;
        private List<Dom_SubRubro> listaSubRubros; 


        public frmSubRubro()
        {
            InitializeComponent();
        }


        

        private void frmSubRubro_Load(object sender, EventArgs e)
        {

            cargar();

        }

        private void cargar()
        {
            subRubroNegocio negocio = new subRubroNegocio();
            listaSubRubros = negocio.listar();

            dgvSubRubro.DataSource = null;
            dgvSubRubro.DataSource = listaSubRubros;
            //dgvSubRubro.Columns["IdSubRubro"].Visible = false;

            //dgvSubRubro.Columns["oPuesto"].HeaderText = "Puesto";
            //dgvSubRubro.Columns["oEstado"].HeaderText = "Estado";

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
