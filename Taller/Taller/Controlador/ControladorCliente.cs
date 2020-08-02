using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taller.Modelo;

namespace Taller.Controlador
{
    class ControladorCliente
    {
        public List<cliente> refrescar()
        {
            List<cliente> listaCliente;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;
                var lst = from d in db.cliente
                          select d;
                lst = lst.OrderBy(u => u.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaCliente = lst.ToList();

            }

            return listaCliente;
        }

        public void nuevo(cliente nuevoCliente)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
        }

        public void editar(cliente editaCliente)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaCliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public cliente buscarId(int? id)
        {
            cliente oCliente = new cliente();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oCliente = db.cliente.Find(id);

            }
            return oCliente;
        }

        public cliente buscarCI(string ci)
        {
            cliente oCliente = new cliente();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oCliente = db.cliente.SingleOrDefault(cli => cli.ci == ci);
            }
            return oCliente;
        }
    }
}
