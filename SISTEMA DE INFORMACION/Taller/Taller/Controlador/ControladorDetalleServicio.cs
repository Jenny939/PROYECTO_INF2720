using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorDetalleServicio
    {
        public void nuevo(det_servicio nuevoDetalleServicio)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.det_servicio.Add(nuevoDetalleServicio);
                db.SaveChanges();
            }
        }

        public List<det_servicio> listarPorFactura(int id_factura)
        {
            List<det_servicio> listaDetServicio;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.det_servicio.Where(d => d.id_factura == id_factura);

                lst = lst.OrderBy(d => d.id);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaDetServicio = lst.ToList();

            }

            return listaDetServicio;
        }
    }


    
}
