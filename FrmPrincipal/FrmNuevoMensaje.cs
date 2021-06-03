using Entities;
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
    public partial class FrmNuevoMensaje : Form
    {
        Mensaje miMensaje;
        
        public FrmNuevoMensaje()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if( !(String.IsNullOrEmpty(txtNombre.Text)) ||
                !(String.IsNullOrEmpty(txtDestino.Text)) ||
                !(String.IsNullOrEmpty(txtMensajeFinal.Text)) )
            {
                miMensaje = new Mensaje(txtNombre.Text, txtDestino.Text, txtMensajeFinal.Text, DateTime.Now);
                //MessageBox.Show(miMensaje.ToString());
                MensajesGuardados.Mensaje = miMensaje;

                //miMensaje.Guardar();      // -> TXT

                //miMensaje.GuardarXml();   // -> XML

                miMensaje.GuardarBynary();  // -> DAT
            }
            else
            {
                MessageBox.Show("Error, llene todos los campos");
            }
            this.txtDestino.Text = string.Empty;
            this.txtMensajeFinal.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }

        private void btnCargarMensaje_Click(object sender, EventArgs e)
        {
            FrmCargaMensaje formCarga = new FrmCargaMensaje();
            formCarga.ShowDialog();
        }
    }
}
