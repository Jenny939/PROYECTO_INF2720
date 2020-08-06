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
using Taller.Controlador;

namespace Taller.Vista
{
    public partial class FrmModificarUsuario : Form
    {
        public int? id;
        usuario oUsuario = null;
        ControladorUsuario controladorUsuario = new ControladorUsuario();

        public FrmModificarUsuario(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {           
            oUsuario = controladorUsuario.buscarId(id);

            txtNombre.Text = oUsuario.nombre;
            txtPaterno.Text = oUsuario.ap_paterno;
            txtMaterno.Text = oUsuario.ap_materno;
            txtCI.Text = oUsuario.ci;
            txtTelefono.Text = oUsuario.telefono;
            txtDireccion.Text = oUsuario.direccion;


            cBoxTipo.SelectedItem = oUsuario.tipo;

            txtCuenta.Text = oUsuario.cuenta;
            txtPassword.Text = oUsuario.pass;

            if (oUsuario.activo == 1)
                rBtnSi.Checked = true;
            else
                rBtnNO.Checked = true;                
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if(ValidarCampos())
            {
                if (id == null)
                {
                    try
                    {
                        oUsuario = new usuario();

                        oUsuario.nombre = txtNombre.Text;
                        oUsuario.ap_paterno = txtPaterno.Text;
                        oUsuario.ap_materno = txtMaterno.Text;
                        oUsuario.ci = txtCI.Text;
                        oUsuario.telefono = txtTelefono.Text;
                        oUsuario.direccion = txtDireccion.Text;


                        oUsuario.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                        oUsuario.cuenta = txtCuenta.Text;
                        oUsuario.pass = txtPassword.Text;
                        if (rBtnSi.Checked == true)
                            oUsuario.activo = 1;
                        else
                            oUsuario.activo = 0;

                        controladorUsuario.nuevo(oUsuario);
                        MessageBox.Show(this, "Usuario Agregado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch(Exception )
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        txtCI.ReadOnly = true;

                        oUsuario.nombre = txtNombre.Text;
                        oUsuario.ap_paterno = txtPaterno.Text;
                        oUsuario.ap_materno = txtMaterno.Text;
                        oUsuario.ci = txtCI.Text;
                        oUsuario.telefono = txtTelefono.Text;
                        oUsuario.direccion = txtDireccion.Text;

                        oUsuario.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                        oUsuario.cuenta = txtCuenta.Text;
                        oUsuario.pass = txtPassword.Text;

                        if (rBtnSi.Checked == true)
                            oUsuario.activo = 1;
                        else
                            oUsuario.activo = 0;

                        controladorUsuario.editar(oUsuario);
                        MessageBox.Show(this, "Usuario Modificado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              //  this.Close();
            }else
                MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarCampos()
        {
            bool ok = true;               
            if(txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese el nombre Completo");
            }
            if (txtPaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPaterno, "Ingrese el Apellido Paterno");
            }
            if (txtMaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMaterno, "Ingrese el Apelllido Materno");
            }
            if (txtCI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCI, "Ingrese un CI");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "Ingrese un Numero de Telefono");
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Ingrese una Direccion");
            }
            if (cBoxTipo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cBoxTipo, "Ingrese un Tipo de Usurio");
            }
            if (txtCuenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCuenta, "Ingrese un mobre de usuario");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Ingrese un Contraseña");
            }
            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPaterno, "");
            errorProvider1.SetError(txtMaterno, "");
            errorProvider1.SetError(txtCI, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(cBoxTipo, "");
            errorProvider1.SetError(txtCuenta, "");
            errorProvider1.SetError(txtPassword, "");
        }

        private void txtCI_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtCI.Text, out num))
            {
                errorProvider1.SetError(txtCI,"Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtCI,"");
            }
        }
        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtTelefono.Text, out num))
            {
                errorProvider1.SetError(txtTelefono, "Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))

                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
