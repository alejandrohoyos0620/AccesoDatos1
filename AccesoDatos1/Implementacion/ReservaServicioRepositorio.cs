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
    public class ReservaServicioRepositorio : IReservaServicios
    {
        public bool ActualizarReservaServicio(ReservaServicioDBModel reservaServicio)
        {
            throw new NotImplementedException();
        }

        public ReservaServicioDBModel BuscarReservaServicio(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaServicioDBModel> ConsultaReservaServicios()
        {
            using (petServicesEntities1 db = new petServicesEntities1())
            {
                IList<reservaServico> listadoReservaServicioBD = db.reservaServicoes.ToList();
                var lista = new MapeadorRepositorioReservaServicio().MapearT1T2(listadoReservaServicioBD).ToList();
                return lista;
            }
        }

        public bool EliminarReservaServicio(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarReservaServicio(ReservaServicioDBModel reservaServicio)
        {
            try
            {
                reservaServico ReservaServicio1 = new MapeadorRepositorioReservaServicio().MapearT2T1(reservaServicio);
                using (petServicesEntities1 db = new petServicesEntities1())
                {
                    db.reservaServicoes.Add(ReservaServicio1);
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
