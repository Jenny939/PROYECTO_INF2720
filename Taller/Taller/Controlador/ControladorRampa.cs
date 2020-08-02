using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorRampa
    {

        public List<rampa> refrescar()
        {
            List<rampa> listaRampa;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;
                var lst = from d in db.rampa
                          select d;
                lst = lst.OrderBy(r => r.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaRampa = lst.ToList();

            }
            //listaRampa.Sort();
            return listaRampa;

        }

        public void nuevo(rampa nuevaRampa)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.rampa.Add(nuevaRampa);
                db.SaveChanges();
            }
        }

        public void editar(rampa editaRampa)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaRampa).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public rampa buscarId(int? id)
        {
            rampa oRampa = new rampa();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oRampa = db.rampa.Find(id);

            }
            return oRampa;
        }
    }

}
