using ContratoAccesoDatos1.Contratos;
using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.Contratos;
using ContratosControladorApp1.DTO;
using ControladorApp1.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Implementacion
{
    public class ControladorReservaServicio : IReservaServicioApp
    {
        IReservaServicios _repositorio;

        public ControladorReservaServicio(IReservaServicios reservaServiciosRep)            
        {
            _repositorio = reservaServiciosRep;
        }
        public bool ActualizarReservaServicio(ReservaServicioDTO reservaServicio)
        {
            throw new NotImplementedException();
        }

        public ReservaServicioDTO BuscarReservaServicio(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaServicioDTO> ConsultaReservaServicios()
        {
            MapeadorControladorReservaServicio mapeador = new MapeadorControladorReservaServicio();
            var ListaReservaServicioDBModel = _repositorio.ConsultaReservaServicios();
            IEnumerable<ReservaServicioDTO> ListaReservaServicioDTO = mapeador.MapearT1T2(ListaReservaServicioDBModel);
            return ListaReservaServicioDTO;

        }

        public bool EliminarReservaServicio(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarReservaServicio(ReservaServicioDTO reservaServicio)
        {
            MapeadorControladorReservaServicio mapeador = new MapeadorControladorReservaServicio();
            ReservaServicioDBModel reservaServicioDBModel = mapeador.MapearT2T1(reservaServicio);
            bool respuesta = _repositorio.RegistrarReservaServicio(reservaServicioDBModel);
            return respuesta;
        }
    }
}
