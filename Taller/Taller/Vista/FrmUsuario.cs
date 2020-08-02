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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        ControladorUsuario controladorUsuario = new ControladorUsuario();

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

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario FrmUsuario = new FrmModificarUsuario();
            FrmUsuario.ShowDialog();
            dataGridView1.DataSource = controladorUsuario.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarUsuario oFrmModificarUsuario = new FrmModificarUsuario(id);
                oFrmModificarUsuario.ShowDialog();
                dataGridView1.DataSource = controladorUsuario.refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    usuario oUsuario = db.usuario.Find(id);
                    db.usuario.Remove(oUsuario);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorUsuario.refrescar();
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorUsuario.refrescar();
        }
    }
}
