using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNuevoMensaje miForm = new FrmNuevoMensaje();
            miForm.MdiParent = FrmMenu.ActiveForm;
            miForm.Show();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCargaMensaje miForm = new FrmCargaMensaje();
            miForm.MdiParent = FrmMenu.ActiveForm;
            miForm.Show();
        }
    }
}
