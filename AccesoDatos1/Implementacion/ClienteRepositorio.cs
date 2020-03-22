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
    public class ClienteRepositorio : ICliente
    {
        public bool ActualizarCliente(ClienteDBModel cliente)
        {
            throw new NotImplementedException();
        }

        public ClienteDBModel BuscarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDBModel> ConsultaClietes()
        {
            using (petServicesEntities1 db = new petServicesEntities1())
            {
                IList<cliente> listadoclientesBD = db.clientes.ToList();
                var lista = new MapeadorRepositorioCliente().MapearT1T2(listadoclientesBD).ToList();
                return lista;
            }
        }

        public bool EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public bool IngresarCliente(ClienteDBModel cliente1)
        {
            try
            {
                cliente clienteDB = new MapeadorRepositorioCliente().MapearT2T1(cliente1);
                using (petServicesEntities1 db = new petServicesEntities1())
                {
                    db.clientes.Add(clienteDB);
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
