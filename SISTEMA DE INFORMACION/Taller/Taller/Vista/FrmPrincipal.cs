using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Taller.Vista;

namespace Taller
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmPrincipal principal = new FrmPrincipal();
            MdiAdministrador administrador = new MdiAdministrador();
            administrador.ShowDialog();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            MdiOperador operador = new MdiOperador();
            operador.ShowDialog();
        }
    }
}
