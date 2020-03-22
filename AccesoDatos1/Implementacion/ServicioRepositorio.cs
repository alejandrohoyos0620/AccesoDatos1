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
    public class ServicioRepositorio : IServicio

    {
        public bool ActualizarServicio(ServicioDBModel servicio)
        {
            throw new NotImplementedException();
        }

        public ServicioDBModel BuscarServicio(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServicioDBModel> ConsultaServicios()
        {
            using (petServicesEntities1 db = new petServicesEntities1())
            {
                IList<servicio> listadoServicioBD = db.servicios.ToList();
                var lista = new MapeadorRepositorioServico().MapearT1T2(listadoServicioBD).ToList();
                return lista;
            }
        }

        public bool EliminarServicio(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarServicio(ServicioDBModel servicio)
        {

            try
            {
                servicio servicio1 = new MapeadorRepositorioServico().MapearT2T1(servicio);
                using(petServicesEntities1 db= new petServicesEntities1())
                {
                    db.servicios.Add(servicio1);
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
