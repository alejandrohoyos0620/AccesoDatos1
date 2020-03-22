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
    public class ControladorCliente : IClienteApp
    {
        ICliente _repositorio;
        public ControladorCliente(ICliente _clienteRep)
        {
            this._repositorio = _clienteRep;
        }

        public bool ActualizarCliente(ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public ClienteDTO BuscarCliente(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDTO> ConsultaClietes()
        {
            MapeadorControladorCliente mapeador = new MapeadorControladorCliente();
            var ListaClienteDBModel = _repositorio.ConsultaClietes();
            IEnumerable<ClienteDTO> listaClienteDTO = mapeador.MapearT1T2(ListaClienteDBModel);
            return listaClienteDTO;
        }

        public bool EliminarCliente(string id)
        {
            throw new NotImplementedException();
        }

        public bool IngresarCliente(ClienteDTO cliente)
        {
            MapeadorControladorCliente mapeador = new MapeadorControladorCliente();
            ClienteDBModel Cliente1= mapeador.MapearT2T1(cliente);
            bool respueta = _repositorio.IngresarCliente(Cliente1);
            return respueta;
        }
    }
}
