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
    public partial class FrmReportesAdministrador : Form
    {
        ControladorUsuario controladorUsuario = new ControladorUsuario();
        ControladorFactura controladorFactura = new ControladorFactura();
        ControladorCliente controladorCliente = new ControladorCliente();

        public FrmReportesAdministrador()
        {
            InitializeComponent();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgReporte.Rows[dgReporte.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void FrmReportesAdministrador_Load(object sender, EventArgs e)
        {
            List<usuario> listaUsuario = controladorUsuario.listarPorOperador();
            foreach (usuario u in listaUsuario)
            {
                String us = u.id + " - " + u.nombre + " " + u.ap_paterno + " " + u.ap_materno;
                cmbOperador.Items.Add(us);
            }
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            if (rdBtnTodo.Checked)
            {
                dgReporte.Rows.Clear();

                List<factura> listaFactura = controladorFactura.listar();

                foreach (factura f in listaFactura)
                {
                    cliente oCliente = controladorCliente.buscarId(f.id_cliente);
                    string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
                    dgReporte.Rows.Add(f.id, f.nro, cliente, f.total);
                }

            }
            else if (rdBtnFecha.Checked)
            {
                dgReporte.Rows.Clear();
                DateTime fecha = dateTimePicker1.Value.Date;

                List<factura> listaFactura = controladorFactura.listarPorFecha(fecha);

                foreach (factura f in listaFactura)
                {
                    cliente oCliente = controladorCliente.buscarId(f.id_cliente);
                    string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
                    dgReporte.Rows.Add(f.id, f.nro, cliente, f.total);
                }
            }
            else if (rdBtnVendedor.Checked)
            {

                
                dgReporte.Rows.Clear();

                string operadorinput = System.Convert.ToString(cmbOperador.SelectedItem);

                string operadordigits = new String(operadorinput.TakeWhile(Char.IsDigit).ToArray());

                int id = System.Convert.ToInt16(operadordigits);

                
                List<factura> listaFactura = controladorFactura.listarPorOperador(id);

                foreach (factura f in listaFactura)
                {
                    cliente oCliente = controladorCliente.buscarId(f.id_cliente);
                    string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
                    dgReporte.Rows.Add(f.id, f.nro, cliente, f.total);
                }
            }

            else if (rdBtnVenFecha.Checked)
            {
                dgReporte.Rows.Clear();

                string operadorinput = System.Convert.ToString(cmbOperador.SelectedItem);

                string operadordigits = new String(operadorinput.TakeWhile(Char.IsDigit).ToArray());

                int id = System.Convert.ToInt16(operadordigits);

                DateTime fecha = dateTimePicker1.Value.Date;
                List<factura> listaFactura = controladorFactura.listarPorIdFecha(id,fecha);

                foreach (factura f in listaFactura)
                {
                    cliente oCliente = controladorCliente.buscarId(f.id_cliente);
                    string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
                    dgReporte.Rows.Add(f.id, f.nro, cliente, f.total);
                }
            }


            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            factura oFactura;
            int? id = GetId();
            if (id != null)
            {
                oFactura = controladorFactura.buscarId(id);
                FrmFactura oFrmFactura = new FrmFactura();
                oFrmFactura.oFactura = oFactura;
                oFrmFactura.ShowDialog();

            }
        }
    }
}
