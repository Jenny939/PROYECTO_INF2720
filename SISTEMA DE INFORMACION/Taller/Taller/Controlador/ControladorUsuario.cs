using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorUsuario
    {
        public List<usuario> refrescar()
        {
            List<usuario> listaUsuario;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;
                var lst = from d in db.usuario
                          select d;
                lst = lst.OrderBy(u => u.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaUsuario = lst.ToList();

            }

            return listaUsuario;
        }

        public void nuevo(usuario nuevoUsuario)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.usuario.Add(nuevoUsuario);
                db.SaveChanges();
            }
        }

        public void editar(usuario editaUsuario)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaUsuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public usuario buscarId(int? id)
        {
            usuario oUsuario = new usuario();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oUsuario = db.usuario.Find(id);

            }
            return oUsuario;
        }
        /*MdiAdministrador administrador = new MdiAdministrador();
        administrador.ShowDialog();
            MdiOperador operador = new MdiOperador();
        operador.ShowDialog();
        */
        public usuario validarUsuario(string usuario, string pass)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                usuario oUsuario;
                var lst = from d in db.usuario
                          where d.cuenta == usuario && d.pass == pass && d.activo == 1
                          select d;

                if (lst.Count() > 0)
                {
                    oUsuario = lst.First();


                }
                else
                    oUsuario = null;

                return oUsuario;

            }
        }
    }
}
