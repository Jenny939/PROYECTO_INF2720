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
    public partial class MdiAdministrador : Form
    {
        public MdiAdministrador()
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

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            adicionarForm(frmUsuario);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRampa_Click(object sender, EventArgs e)
        {
            FrmRampa frmRampa = new FrmRampa();
            adicionarForm(frmRampa);
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            FrmServicio frmServicio = new FrmServicio();
            adicionarForm(frmServicio);
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            FrmTecnico frmTecnico = new FrmTecnico();
            adicionarForm(frmTecnico);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            adicionarForm(frmProducto);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            adicionarForm(frmCliente);
        }
    }
}
