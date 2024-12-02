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
    public partial class frmProveedores : Form
    {

        private List<Dom_Proveedores> listaProveedores;

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar()
        {
            ProveedoresNegocio negocio = new ProveedoresNegocio();
            listaProveedores = negocio.listar();

            dgvProveedores.DataSource = null; 
            dgvProveedores.DataSource = listaProveedores;   

        }
    }
}
