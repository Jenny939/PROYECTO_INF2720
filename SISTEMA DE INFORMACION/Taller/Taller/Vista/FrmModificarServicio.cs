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
    public partial class FrmModificarServicio : Form
    {
        public int? id;
        servicio oServicio = null;
        ControladorServicio controladorServicio = new ControladorServicio();

        public FrmModificarServicio(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }
        private void CargaDatos()
        {

            oServicio = controladorServicio.buscarId(id);

            txtNombre.Text = oServicio.nombre;
            txtTipo.Text = oServicio.tipo;
            txtPrecio.Text = oServicio.precio.ToString();


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
                        oServicio = new servicio();

                        oServicio.nombre = txtNombre.Text;
                        oServicio.tipo = txtTipo.Text;

                        oServicio.precio = float.Parse(txtPrecio.Text);

                        controladorServicio.nuevo(oServicio);
                        MessageBox.Show(this, "Servicio Agregado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        oServicio.nombre = txtNombre.Text;
                        oServicio.tipo = txtTipo.Text;

                        oServicio.precio = float.Parse(txtPrecio.Text);

                        controladorServicio.editar(oServicio);
                        MessageBox.Show(this, "Servicio Modificado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //this.Close();
            }else
            {
                MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if(txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese el Nombre del Servicio");
            }
            if(txtPrecio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrecio, "Ingrese el Precio del Servicio");
            }
            if(txtTipo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTipo, "Inserte el Tipo de Servicio");
            }
            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtTipo, "");
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtPrecio.Text, out num))
            {
                errorProvider1.SetError(txtPrecio, "Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
