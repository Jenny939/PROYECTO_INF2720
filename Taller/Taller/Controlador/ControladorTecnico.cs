using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Modelo;
namespace Taller.Controlador
{
    class ControladorTecnico
    {
        public List<tecnico> refrescar()
        {
            List<tecnico> listaTecnico;
            using (DBTallerEntities db = new DBTallerEntities())
            {


                db.Configuration.LazyLoadingEnabled = false;

                var lst = from d in db.tecnico
                          select d;
                lst = lst.OrderBy(s => s.nombre);// funcion par ordenar  [.OrderBy | OrderByDescending]
                listaTecnico = lst.ToList();

            }

            return listaTecnico;
        }

        public void nuevo(tecnico nuevoTecnico)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.tecnico.Add(nuevoTecnico);
                db.SaveChanges();
            }
        }

        public void editar(tecnico editaTecnico)
        {
            using (DBTallerEntities db = new DBTallerEntities())
            {
                db.Entry(editaTecnico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public tecnico buscarId(int? id)
        {
            tecnico oTecnico = new tecnico();
            using (DBTallerEntities db = new DBTallerEntities())
            {
                oTecnico = db.tecnico.Find(id);

            }
            return oTecnico;
        }
    }
}
