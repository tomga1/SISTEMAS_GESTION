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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubRubro_Click(object sender, EventArgs e)
        {
            frmSubRubro ventanaSubRubro = new frmSubRubro();
            ventanaSubRubro.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores ventanaProveedores = new frmProveedores();
            ventanaProveedores.ShowDialog();
        }
    }
}
