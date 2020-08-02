using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Taller.Vista;
using Taller.Controlador;
using Taller.Modelo;

namespace Taller
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        ControladorUsuario controladorUsuario = new ControladorUsuario();

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmPrincipal principal = new FrmPrincipal();
            MdiAdministrador administrador = new MdiAdministrador();
            administrador.ShowDialog();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
           
            MdiOperador operador = new MdiOperador();
            operador.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario;
            string pass;

            usuario oUsuario;

            usuario = txtUsuario.Text;
            pass = txtPass.Text;

            oUsuario = controladorUsuario.validarUsuario(usuario,pass);

            if (oUsuario == null)
            {
                MessageBox.Show("Usuario o Contraseña incorrecto(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                String adm = "Administrador";
                String ope = "Operador";

                if (adm.Equals(oUsuario.tipo))
                {
                    MdiAdministrador administrador = new MdiAdministrador();
                    administrador.cuentaUsuario = oUsuario;
                    administrador.ShowDialog();
                }
                else
                {
                    if (ope.Equals(oUsuario.tipo))
                    {
                        MdiOperador operador = new MdiOperador();
                        operador.cuentaUsuario = oUsuario;
                        operador.ShowDialog();
                        
                    }
                    else
                        MessageBox.Show("incorrecto(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }




        }
    }
}
