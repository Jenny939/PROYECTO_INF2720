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
            if (id == null)
            {
                oServicio = new servicio();

                oServicio.nombre = txtNombre.Text;
                oServicio.tipo = txtTipo.Text;

                oServicio.precio = float.Parse(txtPrecio.Text);

                controladorServicio.nuevo(oServicio);
            }
            else
            {
                oServicio.nombre = txtNombre.Text;
                oServicio.tipo = txtTipo.Text;

                oServicio.precio = float.Parse(txtPrecio.Text);

                controladorServicio.editar(oServicio);
            }
            this.Close();
        }
    }
}
