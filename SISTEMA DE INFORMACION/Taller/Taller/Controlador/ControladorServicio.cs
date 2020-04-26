using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorServicio
    {
        public List<servicio> refrescar()
        {
            List<servicio> listaServicio;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = from d in db.servicio
                          select d;
                lst = lst.OrderBy(s => s.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaServicio = lst.ToList();

            }

            return listaServicio;
        }

        public void nuevo(servicio nuevoServicio)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.servicio.Add(nuevoServicio);
                db.SaveChanges();
            }
        }

        public void editar(servicio editaServicio)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaServicio).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public servicio buscarId(int? id)
        {
            servicio oServicio = new servicio();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oServicio = db.servicio.Find(id);

            }
            return oServicio;
        }
    }
}
