using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Modelo;
namespace Taller.Controlador
{
    class ControladorFactura
    {
        public factura nuevo(factura nuevoFactura)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.factura.Add(nuevoFactura);
                db.SaveChanges();
            }
            return nuevoFactura;
        }

        public void editar(factura editaFactura)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaFactura).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public factura buscarId(int? id)
        {
            factura oFactura = new factura();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oFactura = db.factura.Find(id);

            }
            return oFactura;
        }

        public List<factura> listar()
        {
            List<factura> listaFactura;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;
                var lst = from d in db.factura
                          select d;
                lst = lst.OrderBy(r => r.nro);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaFactura = lst.ToList();

            }

            return listaFactura;
        }

        public List<factura> listarPorOperador(int id)
        {
            List<factura> listaFactura;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.factura.Where(f => f.id_usuario == id);

                lst = lst.OrderBy(f => f.nro);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaFactura = lst.ToList();

            }

            return listaFactura;
        }


        public List<factura> listarPorFecha(DateTime fecha)
        {
            List<factura> listaFactura;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.factura.Where(f => f.fecha == fecha);

                lst = lst.OrderBy(f => f.nro);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaFactura = lst.ToList();

            }

            return listaFactura;
        }

        

        public List<factura> listarPorIdFecha(int id_usuario, DateTime fecha)
        {
            List<factura> listaFactura;

            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = db.factura.Where(i => i.id_usuario == id_usuario).Where(i => i.fecha == fecha);

                lst = lst.OrderBy(i => i.nro);// funcion par ordenar  [.OrderBy | OrderByDescending]

                listaFactura = lst.ToList();

            }

            return listaFactura;
        }

        
    }
}
