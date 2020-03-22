using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
    public interface ICliente
    {
        bool IngresarCliente(ClienteDBModel cliente);
        ClienteDBModel BuscarCliente(int id);
        bool EliminarCliente(int id);
        bool ActualizarCliente(ClienteDBModel cliente);
        IEnumerable<ClienteDBModel> ConsultaClietes();
    }
}
