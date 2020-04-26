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
    }
}
