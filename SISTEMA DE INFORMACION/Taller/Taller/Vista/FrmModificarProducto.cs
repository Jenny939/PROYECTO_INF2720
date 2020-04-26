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
    public partial class FrmModificarProducto : Form
    {

        public int? id;
        producto oProducto = null;
        ControladorProducto controladorProducto = new ControladorProducto();

        public FrmModificarProducto(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {
            
            oProducto = controladorProducto.buscarId(id);

            txtNombre.Text = oProducto.nombre;

            txtCompra.Text = Convert.ToString(oProducto.precio_compra);
            txtVenta.Text = Convert.ToString(oProducto.precio_venta);

            cBoxTipo.SelectedItem = oProducto.tipo;

            txtStock.Text = Convert.ToString(oProducto.stock);
            txtMarca.Text = oProducto.marca;
            txtModelo.Text = oProducto.modelo;



        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                oProducto = new producto();

                oProducto.nombre = txtNombre.Text;

                oProducto.precio_compra= float.Parse(txtCompra.Text);
                oProducto.precio_venta=float.Parse(txtVenta.Text);

                oProducto.tipo = Convert.ToString(cBoxTipo.SelectedItem);
                
                oProducto.stock= Convert.ToInt32(txtStock.Text);

                oProducto.marca= txtMarca.Text;
                oProducto.modelo = txtModelo.Text;

                controladorProducto.nuevo(oProducto);
            }
            else
            {
                oProducto.nombre = txtNombre.Text;

                oProducto.precio_compra = float.Parse(txtCompra.Text);
                oProducto.precio_venta = float.Parse(txtVenta.Text);

                oProducto.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                oProducto.stock = Convert.ToInt32(txtStock.Text);

                oProducto.marca = txtMarca.Text;
                oProducto.modelo = txtModelo.Text;

                controladorProducto.editar(oProducto);
            }
            this.Close();
        }
                        
    }
}
