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
    public class ControladorReserva : IReservaApp
    {
        IReserva _repositorio;
        public ControladorReserva(IReserva reservaRep)
        {
            _repositorio = reservaRep;
        }
        public bool ActualizarReserva(ReservaDTO reserva)
        {
            throw new NotImplementedException();
        }

        public ReservaDTO BuscarReserva(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaDTO> ConsultaReserva()
        {
            MapeadorControladorReserva mapeador = new MapeadorControladorReserva();
            var ListaReserva = _repositorio.ConsultaReserva();
            IEnumerable<ReservaDTO> ListaReservaDTO = mapeador.MapearT1T2(ListaReserva);
            return ListaReservaDTO;
        }

        public bool EliminarReserva(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarReserva(ReservaDTO reserva)
        {
            MapeadorControladorReserva mapeador = new MapeadorControladorReserva();
            ReservaDBModel reservaDBModel = mapeador.MapearT2T1(reserva);
            bool Respuesta = _repositorio.RegistrarReserva(reservaDBModel);
            return Respuesta;
        }
    }
}
