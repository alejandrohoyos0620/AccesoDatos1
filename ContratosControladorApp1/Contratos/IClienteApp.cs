using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
    public interface IClienteApp
    {
        bool IngresarCliente(ClienteDTO cliente);
        ClienteDTO BuscarCliente(String id);
        bool EliminarCliente(string id);
        bool ActualizarCliente(ClienteDTO cliente);
        IEnumerable<ClienteDTO> ConsultaClietes();
    }
}
