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
    public partial class FrmModificarRampa : Form
    {
        public int? id;
        rampa oRampa = null;
        ControladorRampa controladorRampa = new ControladorRampa();

        public FrmModificarRampa(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {
            //using (DBTallerEntities db = new DBTallerEntities())
            //{
            //    oRampa = db.rampa.Find(id);
            //    txtNombre.Text = oRampa.nombre;
            //    txtTipo.Text = oRampa.tipo;
            //}
            oRampa = controladorRampa.buscarId(id);
            txtNombre.Text = oRampa.nombre;
            txtTipo.Text = oRampa.tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (DBTallerEntities db = new DBTallerEntities())
            //{
            //    if (id==null)
            //        oRampa = new rampa();

            //    oRampa.nombre = txtNombre.Text;
            //    oRampa.tipo = txtTipo.Text;

            //    if (id==null)
            //    db.rampa.Add(oRampa);
            //    else
            //    {
            //        db.Entry(oRampa).State = System.Data.Entity.EntityState.Modified;
            //    }

            //    db.SaveChanges();

            //    this.Close();
            //}
            
            if (id == null)
            {
                oRampa = new rampa();
                oRampa.nombre = txtNombre.Text;
                oRampa.tipo = txtTipo.Text;
                controladorRampa.nuevo(oRampa);
            }
            else
            {
                oRampa.nombre = txtNombre.Text;
                oRampa.tipo = txtTipo.Text;
                controladorRampa.editar(oRampa);
            }
            this.Close();
        }

        private void FrmModificarRampa_Load(object sender, EventArgs e)
        {

        }
    }
}
