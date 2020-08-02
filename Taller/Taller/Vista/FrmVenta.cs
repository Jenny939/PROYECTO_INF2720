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
       
        ControladorCliente controladorCliente = new ControladorCliente();
        ControladorProducto controladorProducto = new ControladorProducto();
        ControladorServicio controladorServicio = new ControladorServicio();
        ControladorDetalleProducto controladorDetalleProducto = new ControladorDetalleProducto();
        ControladorDetalleServicio controladorDetalleServicio = new ControladorDetalleServicio();
        ControladorFactura controladorFactura= new ControladorFactura();

        ControladorRampa controladorRampa = new ControladorRampa();
        ControladorTecnico controladorTecnico = new ControladorTecnico();



        public FrmVenta()
        {
            InitializeComponent();
        }

        

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

            List<tecnico> listaTecnico = controladorTecnico.refrescar();
            foreach(tecnico t in listaTecnico)
            {
                String tec = t.id + " - " + t.nombre + " " +t.ap_paterno;
                cmbTecnico.Items.Add(tec);
            }


            List<rampa> listaRampa = controladorRampa.refrescar();
            foreach(rampa r in listaRampa)
            {
                String ram = r.id + " - " + r.nombre;
                cmbRampa.Items.Add(ram);
            }
           
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            det_servicio oDetalleServicio = null;

            det_producto oDetalleProducto = null;

            factura oFactura = new factura();
            cliente oCliente = null;
            

            usuario oUsuario = this.cuentaUsuario;

            string ci;
            ci = txtCI.Text;

            double total = 0;

            
            if (txtCliente.Text == "")
                MessageBox.Show("NECESARIO CI DEL CLIENTE PARA REALIZAR VENTA");
            
            else

            {
                oCliente = controladorCliente.buscarCI(ci);

               

                oFactura.nro = 99999;
                oFactura.id_cliente = oCliente.id;
                oFactura.id_usuario = oUsuario.id;
                oFactura.fecha = DateTime.Today;
                
                oFactura = controladorFactura.nuevo(oFactura);


                for (int i = 0; i < dgDetalle.RowCount - 1; i++)

                {
                    string t = dgDetalle.Rows[i].Cells[5].Value.ToString();
                    int id = System.Convert.ToInt16(dgDetalle.CurrentRow.Cells[0].Value);

                    total += Convert.ToDouble(dgDetalle.Rows[i].Cells[4].Value.ToString());

                    if (string.Equals(t, "Servicio"))
                    {

                        oDetalleServicio = new det_servicio();

                        oDetalleServicio.id_servicio = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[0].Value);
                        oDetalleServicio.id_factura = oFactura.id;
                        oDetalleServicio.cantidad = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[2].Value);
                        oDetalleServicio.precio_unitario = System.Convert.ToDouble(dgDetalle.Rows[i].Cells[3].Value);
                        oDetalleServicio.subtotal = System.Convert.ToDouble(dgDetalle.Rows[i].Cells[4].Value);

                        oDetalleServicio.id_tecnico = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[6].Value);
                        oDetalleServicio.id_rampa = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[7].Value);

                        controladorDetalleServicio.nuevo(oDetalleServicio);
                        
                    }

                    if (string.Equals(t, "Producto"))
                    {
                        
                        oDetalleProducto = new det_producto();
                                              
                        oDetalleProducto.id_producto = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[0].Value);
                        oDetalleProducto.id_factura = oFactura.id;
                        oDetalleProducto.cantidad = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[2].Value);
                        oDetalleProducto.precio_unitario = System.Convert.ToDouble (dgDetalle.Rows[i].Cells[3].Value);
                        oDetalleProducto.subtotal = System.Convert.ToDouble(dgDetalle.Rows[i].Cells[4].Value);

                        controladorDetalleProducto.nuevo(oDetalleProducto);
                                                
                    }

                }

                oFactura.total = total;
                controladorFactura.editar(oFactura);
                FrmFactura frmFactura = new FrmFactura();
                frmFactura.oFactura = oFactura;
                frmFactura.ShowDialog();
            }
            
            

        

        }

        private void btnAServ_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgServicios.SelectedRows)
            {
                
                string nombreServicio = dgServicios.CurrentRow.Cells[1].Value.ToString();
                         
                float precioServicio = System.Convert.ToSingle(dgServicios.CurrentRow.Cells[3].Value);
                int cantidadServicio = System.Convert.ToInt16(txtCantServ.Text);

                float subtotal = precioServicio * cantidadServicio;
                int id = System.Convert.ToInt16(dgServicios.CurrentRow.Cells[0].Value);

                //agregar rampa 

                string rampainput = System.Convert.ToString(cmbRampa.SelectedItem); 

                string rampadigits = new String(rampainput.TakeWhile(Char.IsDigit).ToArray());

               
                //agregar tecnico

                string tecnicoinput = System.Convert.ToString(cmbTecnico.SelectedItem);

                string tecnicodigits = new String(tecnicoinput.TakeWhile(Char.IsDigit).ToArray());

                
                dgDetalle.Rows.Add(id,nombreServicio, cantidadServicio, precioServicio, subtotal,"Servicio",tecnicodigits,rampadigits);

            }
        }

        private void btnAProd_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgProductos.SelectedRows)
            {
                string nombreProducto = dgProductos.CurrentRow.Cells[1].Value.ToString();

                float precioProducto = System.Convert.ToSingle(dgProductos.CurrentRow.Cells[3].Value);
                int cantidadProducto = System.Convert.ToInt16(txtCantProd.Text);

                float subtotal = precioProducto * cantidadProducto;
                int id = System.Convert.ToInt16(dgProductos.CurrentRow.Cells[0].Value);
                dgDetalle.Rows.Add(id,nombreProducto, cantidadProducto, precioProducto, subtotal,"Producto");

            }
                
                       
        }
    }
}
