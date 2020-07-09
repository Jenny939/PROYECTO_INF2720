using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller.Vista
{
    public partial class MdiOperador : Form
    {
        public MdiOperador()
        {
            InitializeComponent();
        }

        private void adicionarForm(Form form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            adicionarForm(frmCliente);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            adicionarForm(frmVenta);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            FrmCuenta frmCuenta = new FrmCuenta();
            frmCuenta.cuentaUsuario = this.cuentaUsuario;
            adicionarForm(frmCuenta);
        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            FrmReservaciones frmReservaciones = new FrmReservaciones();
            adicionarForm(frmReservaciones);
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            FrmReportesOperador frmReportesOperador = new FrmReportesOperador();
            adicionarForm(frmReportesOperador);
        }
    }
}
