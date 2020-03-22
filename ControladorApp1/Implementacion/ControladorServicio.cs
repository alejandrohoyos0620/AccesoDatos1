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
    public class ControladorServicio : IServicioApp
    {
        IServicio _repositorio;
        public ControladorServicio(IServicio servicioRep){
            _repositorio = servicioRep;
        }
        public bool ActualizarServicio(ServicioDTO servicio)
        {
            throw new NotImplementedException();
        }

        public ServicioDTO BuscarServicio(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServicioDTO> ConsultaServicios()
        {

            MapeadorControladorServicio mapeador = new MapeadorControladorServicio();
            var ListaServicioDBModel = _repositorio.ConsultaServicios();
            IEnumerable<ServicioDTO> ListaServicioDTO = mapeador.MapearT1T2(ListaServicioDBModel);
            return ListaServicioDTO;
        }

        public bool EliminarServicio(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarServicio(ServicioDTO servicio)
        {
            MapeadorControladorServicio mapeador = new MapeadorControladorServicio();
            ServicioDBModel servicioDBModel = mapeador.MapearT2T1(servicio);
            bool Respuesta = _repositorio.RegistrarServicio(servicioDBModel);
            return Respuesta;
        }
    }
}
