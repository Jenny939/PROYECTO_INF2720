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
    public partial class FrmModificarCliente : Form
    {
        public int? id;
        cliente oCliente = null;
        ControladorCliente controladorCliente = new ControladorCliente();

        public FrmModificarCliente(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }
        private void CargaDatos()
        {
            oCliente = controladorCliente.buscarId(id);

            txtNombre.Text = oCliente.nombre;
            txtPaterno.Text = oCliente.ap_paterno;
            txtMaterno.Text = oCliente.ap_materno;
            txtCI.Text = oCliente.ci;
            txtTelefono.Text = oCliente.telefono;
            txtDireccion.Text = oCliente.direccion;            
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
                        oCliente = new cliente();

                        oCliente.nombre = txtNombre.Text;
                        oCliente.ap_paterno = txtPaterno.Text;
                        oCliente.ap_materno = txtMaterno.Text;
                        oCliente.ci = txtCI.Text;
                        oCliente.telefono = txtTelefono.Text;
                        oCliente.direccion = txtDireccion.Text;

                        controladorCliente.nuevo(oCliente);
                        MessageBox.Show(this, "Cliente Agregado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                    try
                    {
                        oCliente.nombre = txtNombre.Text;
                        oCliente.ap_paterno = txtPaterno.Text;
                        oCliente.ap_materno = txtMaterno.Text;
                        oCliente.ci = txtCI.Text;
                        oCliente.telefono = txtTelefono.Text;
                        oCliente.direccion = txtDireccion.Text;

                        controladorCliente.editar(oCliente);
                        MessageBox.Show(this, "Cliente Modificado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        //    this.Close();
            }
            else
            {
                MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Inserte el Nombre del Cliente");
            }
            if(txtPaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPaterno, "Inserte El apellido Paterno del Cliente");
            }
            if(txtMaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMaterno, "Inserte el Apellido Materno del Cliente");
            }
            if(txtCI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCI, "Inserte la Cedula de Identidad del Cliente");
            }
            if(txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "Inserte el Numero Telefonico del Cliente");
            }
            if(txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Inserte la Direccion del Cliente");
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
        }

        private void txtCI_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtCI.Text, out num))
            {
                errorProvider1.SetError(txtCI, "Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtCI, "");
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
            if (Char.IsNumber(e.KeyChar))
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
