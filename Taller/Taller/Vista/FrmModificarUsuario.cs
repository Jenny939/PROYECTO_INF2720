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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                oUsuario = new usuario();

                oUsuario.nombre= txtNombre.Text ;
                oUsuario.ap_paterno= txtPaterno.Text ;
                oUsuario.ap_materno= txtMaterno.Text ;
                oUsuario.ci= txtCI.Text;
                oUsuario.telefono= txtTelefono.Text;
                oUsuario.direccion=txtDireccion.Text;


                oUsuario.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                oUsuario.cuenta= txtCuenta.Text;
                oUsuario.pass= txtPassword.Text;
                if (rBtnSi.Checked == true)
                    oUsuario.activo = 1;
                else
                    oUsuario.activo = 0;

                controladorUsuario.nuevo(oUsuario);
            }
            else
            {
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
            }
            this.Close();
        }
    }
}
