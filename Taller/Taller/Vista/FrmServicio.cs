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
    public partial class FrmServicio : Form
    {
        public FrmServicio()
        {
            InitializeComponent();
        }
        ControladorServicio controladorServicio = new ControladorServicio();

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModificarServicio FrmServicio = new FrmModificarServicio();
            FrmServicio.ShowDialog();
            dataGridView1.DataSource = controladorServicio.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarServicio oFrmModificarServicio = new FrmModificarServicio(id);
                oFrmModificarServicio.ShowDialog();
                dataGridView1.DataSource = controladorServicio.refrescar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    servicio oServicio = db.servicio.Find(id);
                    db.servicio.Remove(oServicio);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorServicio.refrescar();
            }
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorServicio.refrescar();
        }
    }
}
