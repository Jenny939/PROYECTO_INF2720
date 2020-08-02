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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        ControladorProducto controladorProducto = new ControladorProducto();

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
            FrmModificarProducto FrmProducto = new FrmModificarProducto();
            FrmProducto.ShowDialog();
            dataGridView1.DataSource = controladorProducto.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarProducto oFrmModificarProducto = new FrmModificarProducto(id);
                oFrmModificarProducto.ShowDialog();
                dataGridView1.DataSource = controladorProducto.refrescar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    producto oProducto = db.producto.Find(id);
                    db.producto.Remove(oProducto);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorProducto.refrescar();
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorProducto.refrescar();
        }
    }
}
