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
    public partial class FrmModificarTecnico : Form
    {

        public int? id;
        tecnico oTecnico = null;
        ControladorTecnico controladorTecnico = new ControladorTecnico();


        public FrmModificarTecnico(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            CargaDatos();
        }

        private void CargaDatos()
        {

            oTecnico = controladorTecnico.buscarId(id);
            txtNombre.Text = oTecnico.nombre;
            txtPaterno.Text = oTecnico.ap_paterno;
            txtMaterno.Text = oTecnico.ap_materno;
            txtCI.Text = oTecnico.ci;
            txtTelefono.Text = oTecnico.telefono;
            txtDireccion.Text = oTecnico.direccion;


            cBoxEspecialidad.SelectedItem = oTecnico.especialidad;

            if (oTecnico.activo == 1)
                rBtnSi.Checked = true;
            else
                rBtnNo.Checked = true;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                oTecnico = new tecnico();

                oTecnico.nombre = txtNombre.Text;
                oTecnico.ap_paterno = txtPaterno.Text;
                oTecnico.ap_materno = txtMaterno.Text;
                oTecnico.ci = txtCI.Text;
                oTecnico.telefono = txtTelefono.Text;
                oTecnico.direccion = txtDireccion.Text;


                oTecnico.especialidad = Convert.ToString(cBoxEspecialidad.SelectedItem);

                if (rBtnSi.Checked == true)
                    oTecnico.activo = 1;
                else
                    oTecnico.activo = 0;

                controladorTecnico.nuevo(oTecnico);
            }
            else
            {
                oTecnico.nombre = txtNombre.Text;
                oTecnico.ap_paterno = txtPaterno.Text;
                oTecnico.ap_materno = txtMaterno.Text;
                oTecnico.ci = txtCI.Text;
                oTecnico.telefono = txtTelefono.Text;
                oTecnico.direccion = txtDireccion.Text;

                oTecnico.especialidad = Convert.ToString(cBoxEspecialidad.SelectedItem);

              

                if (rBtnSi.Checked == true)
                    oTecnico.activo = 1;
                else
                    oTecnico.activo = 0;

                controladorTecnico.editar(oTecnico);
            }
            this.Close();
        }
    }
}
