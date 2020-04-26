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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        ControladorCliente controladorCliente = new ControladorCliente();
        ControladorProducto controladorProducto = new ControladorProducto();
        ControladorServicio controladorServicio = new ControladorServicio();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cliente oCliente;
            string ci;
            ci = txtCI.Text;

            oCliente=controladorCliente.buscarCI(ci);
            if (oCliente != null)
                txtCliente.Text = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
            else
                MessageBox.Show("NO EXISTE EL CLIENTE");
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FrmModificarCliente FrmCliente = new FrmModificarCliente();
            FrmCliente.ShowDialog();
            
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            
            dgProductos.DataSource = controladorProducto.refrescar();


            
            dgServicios.DataSource = controladorServicio.refrescar();
        }
    }
}
