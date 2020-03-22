using AccesoDatos1.Mapeadores;
using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.Contratos;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Implementacion
{
    public class CalificacionesRepositorio : ICalificaciones
    {
        public bool ActualizarCalificacion(CalificacionesDBModel calificacion)
        {
            throw new NotImplementedException();
        }

        public CalificacionesDBModel BuscarCalificacion(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalificacionesDBModel> ConsultaCalificaciones()
        {
            using(petServicesEntities1 db= new petServicesEntities1())
            {
                IList<calificacione> listaCalificacionesDB = db.calificaciones.ToList();
                var lista = new MapeadorRepositorioCalificaciones().MapearT1T2(listaCalificacionesDB);
                return lista;
            }
        }

        public bool EliminarCalificacion(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarCalificacion(CalificacionesDBModel calificacion)
        {
            try
            {
                calificacione califi = new MapeadorRepositorioCalificaciones().MapearT2T1(calificacion);
                using (petServicesEntities1 db = new petServicesEntities1())
                {
                    db.calificaciones.Add(califi);
                    db.SaveChanges();
                    return true;
                       
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
