using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorReservacion
    {
        public List<reservacion> listarPorFecha(DateTime fecha)
        {
            List<reservacion> listaReservacion;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.reservacion.Where(r => r.fecha == fecha);

                lst = lst.OrderBy(r => r.horario);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaReservacion= lst.ToList();

            }

            return listaReservacion;
        }

        public void nuevo(reservacion nuevoReservacion)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.reservacion.Add(nuevoReservacion);
                db.SaveChanges();
            }
        }

        public reservacion buscarId(int? id)
        {
            reservacion oReservacion = new reservacion();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oReservacion = db.reservacion.Find(id);

            }
            return oReservacion;
        }

        public void editar(reservacion editaReservacion)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaReservacion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
