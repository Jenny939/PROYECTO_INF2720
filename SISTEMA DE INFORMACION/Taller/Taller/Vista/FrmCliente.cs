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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        ControladorCliente controladorCliente = new ControladorCliente();

        #region HELPER

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorCliente.refrescar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModificarCliente FrmCliente = new FrmModificarCliente();
            FrmCliente.ShowDialog();
            dataGridView1.DataSource = controladorCliente.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarCliente oFrmModificarCliente = new FrmModificarCliente(id);
                oFrmModificarCliente.ShowDialog();
                dataGridView1.DataSource = controladorCliente.refrescar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    cliente oCliente = db.cliente.Find(id);
                    db.cliente.Remove(oCliente);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorCliente.refrescar();
            }
        }
    }
}
