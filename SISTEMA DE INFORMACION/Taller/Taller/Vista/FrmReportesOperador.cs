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
    public partial class FrmReportesOperador : Form
    {

        ControladorFactura controladorFactura = new ControladorFactura();
        ControladorCliente controladorCliente = new ControladorCliente();

        private int? GetId()
        {
            try
            {
                return int.Parse(dgReportesOperador.Rows[dgReportesOperador.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        public FrmReportesOperador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportesOperador_Load(object sender, EventArgs e)
        {



        }

       
        private void btnListar_Click(object sender, EventArgs e)
        {

            usuario oUsuario = this.cuentaUsuario;
            dgReportesOperador.Rows.Clear();

            DateTime fecha = dateTimePicker1.Value.Date;
            

            List<factura> listaFactura = controladorFactura.listarPorIdFecha(oUsuario.id, fecha);
            double total = 0;

            foreach (factura f in listaFactura)
            {
                cliente oCliente = controladorCliente.buscarId(f.id_cliente);
                string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
                dgReportesOperador.Rows.Add(f.id, f.nro, cliente, f.total);

                total += f.total;

            }

            lblTotal.Text = "TOTAL: " + total;

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

        private void FrmReportesOperador_Load_1(object sender, EventArgs e)
        {

        }
    }
}
