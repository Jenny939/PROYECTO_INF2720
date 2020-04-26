using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Taller.Modelo;


namespace Taller.Controlador
{
    class ControladorProducto
    {
        public List<producto> refrescar()
        {
            List<producto> listaProducto;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;
                var lst = from d in db.producto
                          select d;
                lst = lst.OrderBy(u => u.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaProducto = lst.ToList();

            }

            return listaProducto;
        }

        public void nuevo(producto nuevoProducto)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.producto.Add(nuevoProducto);
                db.SaveChanges();
            }
        }

        public void editar(producto editaProducto)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaProducto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public producto buscarId(int? id)
        {
            producto oProducto = new producto();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oProducto = db.producto.Find(id);

            }
            return oProducto;
        }
    }
}
