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
    public partial class FrmTecnico : Form
    {
        public FrmTecnico()
        {
            InitializeComponent();
        }

        ControladorTecnico controladorTecnico = new ControladorTecnico();

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

        private void FrmTecnico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorTecnico.refrescar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModificarTecnico FrmTecnico = new FrmModificarTecnico();
            FrmTecnico.ShowDialog();
            dataGridView1.DataSource = controladorTecnico.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarTecnico oFrmModificarTecnico = new FrmModificarTecnico(id);
                oFrmModificarTecnico.ShowDialog();
                dataGridView1.DataSource = controladorTecnico.refrescar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    tecnico oTecnico = db.tecnico.Find(id);
                    db.tecnico.Remove(oTecnico);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorTecnico.refrescar();
            }
        }
    }
}
