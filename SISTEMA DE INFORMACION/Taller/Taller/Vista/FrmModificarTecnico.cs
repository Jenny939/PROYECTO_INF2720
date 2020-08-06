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
    public partial class FrmModificarTecnico : Form
    {

        public int? id;
        tecnico oTecnico = null;
        ControladorTecnico controladorTecnico = new ControladorTecnico();


        public FrmModificarTecnico(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            CargaDatos();
        }

        private void CargaDatos()
        {

            oTecnico = controladorTecnico.buscarId(id);
            txtNombre.Text = oTecnico.nombre;
            txtPaterno.Text = oTecnico.ap_paterno;
            txtMaterno.Text = oTecnico.ap_materno;
            txtCI.Text = oTecnico.ci;
            txtTelefono.Text = oTecnico.telefono;
            txtDireccion.Text = oTecnico.direccion;


            cBoxEspecialidad.SelectedItem = oTecnico.especialidad;

            if (oTecnico.activo == 1)
                rBtnSi.Checked = true;
            else
                rBtnNo.Checked = true;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                if (id == null)
                {

                    try
                    {
                        oTecnico = new tecnico();

                        oTecnico.nombre = txtNombre.Text;
                        oTecnico.ap_paterno = txtPaterno.Text;
                        oTecnico.ap_materno = txtMaterno.Text;
                        oTecnico.ci = txtCI.Text;
                        oTecnico.telefono = txtTelefono.Text;
                        oTecnico.direccion = txtDireccion.Text;


                        oTecnico.especialidad = Convert.ToString(cBoxEspecialidad.SelectedItem);

                        if (rBtnSi.Checked == true)
                            oTecnico.activo = 1;
                        else
                            oTecnico.activo = 0;

                        controladorTecnico.nuevo(oTecnico);
                        MessageBox.Show(this, "Tecnico Agregado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { 
                    try
                    {
                        oTecnico.nombre = txtNombre.Text;
                        oTecnico.ap_paterno = txtPaterno.Text;
                        oTecnico.ap_materno = txtMaterno.Text;
                        oTecnico.ci = txtCI.Text;
                        oTecnico.telefono = txtTelefono.Text;
                        oTecnico.direccion = txtDireccion.Text;

                        oTecnico.especialidad = Convert.ToString(cBoxEspecialidad.SelectedItem);



                        if (rBtnSi.Checked == true)
                            oTecnico.activo = 1;
                        else
                            oTecnico.activo = 0;

                        controladorTecnico.editar(oTecnico); 
                        MessageBox.Show(this, "Tecnico Modificado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               // this.Close();
            }else
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
            if (cBoxEspecialidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cBoxEspecialidad, "Ingrese un Tipo de Usurio");
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
            errorProvider1.SetError(cBoxEspecialidad, "");
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
    }
}
