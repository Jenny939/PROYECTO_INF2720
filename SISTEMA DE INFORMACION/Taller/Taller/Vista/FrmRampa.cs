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
    
    public partial class FrmRampa : Form
    {
        public FrmRampa()
        {
            InitializeComponent();
           
        }

        ControladorRampa controladorRampa = new ControladorRampa();

        #region HELPER
        //private void Refrescar()
        //{
        //    using (DBTallerEntities db = new DBTallerEntities())
        //    {
        //        db.Configuration.LazyLoadingEnabled = false;
        //        var lst = from d in db.rampa
        //                  select d;
        //        dataGridView1.DataSource = lst.ToList();
                
        //    }
        //}

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

        private void FrmRampa_Load(object sender, EventArgs e)
        {
            //Refrescar();
            dataGridView1.DataSource= controladorRampa.refrescar();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModificarRampa FrmRampa = new FrmModificarRampa();
            FrmRampa.ShowDialog();
            dataGridView1.DataSource = controladorRampa.refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmModificarRampa oFrmModificarRampa = new FrmModificarRampa(id);
                oFrmModificarRampa.ShowDialog();
                dataGridView1.DataSource = controladorRampa.refrescar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBTallerEntities db = new DBTallerEntities())
                {
                    rampa oRampa = db.rampa.Find(id);
                    db.rampa.Remove(oRampa);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = controladorRampa.refrescar();
            }
        }
    }
}
