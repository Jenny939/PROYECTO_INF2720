using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.Controlador;
namespace Taller.Vista

{
    public partial class FrmCambiarPass : Form
    {
        public FrmCambiarPass()
        {
            InitializeComponent();
        }

        ControladorUsuario controladorUsuario = new ControladorUsuario();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtAntigua.Text == cuentaUsuario.pass )
            {
                if(txtNueva.Text==txtConfirmar.Text)
                {
                    cuentaUsuario.pass = txtNueva.Text;

                    controladorUsuario.editar(cuentaUsuario);

                    this.Close();


                }

                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else

            {

                MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
