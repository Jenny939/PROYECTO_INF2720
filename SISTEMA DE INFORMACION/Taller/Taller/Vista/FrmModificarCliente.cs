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
            if (id == null)
            {
                oCliente = new cliente();

                oCliente.nombre = txtNombre.Text;
                oCliente.ap_paterno=txtPaterno.Text;
                oCliente.ap_materno= txtMaterno.Text;
                oCliente.ci= txtCI.Text;
                oCliente.telefono= txtTelefono.Text;
                oCliente.direccion= txtDireccion.Text;

                controladorCliente.nuevo(oCliente);
            }
            else
            {
                oCliente.nombre = txtNombre.Text;
                oCliente.ap_paterno = txtPaterno.Text;
                oCliente.ap_materno = txtMaterno.Text;
                oCliente.ci = txtCI.Text;
                oCliente.telefono = txtTelefono.Text;
                oCliente.direccion = txtDireccion.Text;

                controladorCliente.editar(oCliente);
            }
            this.Close();
        }
    }
    
}
