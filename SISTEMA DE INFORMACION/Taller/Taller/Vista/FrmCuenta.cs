using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.Modelo;


namespace Taller.Vista
{
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            FrmCambiarPass frmCambiarPass = new FrmCambiarPass();
            frmCambiarPass.cuentaUsuario = this.cuentaUsuario; 
            frmCambiarPass.ShowDialog();
        }

        private void FrmCuentaOperador_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cuentaUsuario.nombre;
            lblApPaterno.Text = cuentaUsuario.ap_paterno;
            lblApMaterno.Text = cuentaUsuario.ap_materno;
            lblCI.Text = cuentaUsuario.ci;
            lblTelefono.Text = cuentaUsuario.telefono;
            lblDireccion.Text = cuentaUsuario.direccion;
            lblTipo.Text = cuentaUsuario.tipo;
            lblCuenta.Text = cuentaUsuario.cuenta;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblApPaterno_Click(object sender, EventArgs e)
        {

        }
    }
}
