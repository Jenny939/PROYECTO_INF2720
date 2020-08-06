using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorDetalleProducto
    {
        public void nuevo(det_producto nuevoDetalleProducto)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.det_producto.Add(nuevoDetalleProducto);
                db.SaveChanges();
            }
        }

        public List<det_producto> listarPorFactura (int id_factura)
        {
            List<det_producto> listaDetProducto;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.det_producto.Where(d => d.id_factura == id_factura);

                lst = lst.OrderBy(d => d.id);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaDetProducto = lst.ToList();

            }

            return listaDetProducto;
        }



    }
}
