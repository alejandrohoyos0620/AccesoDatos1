using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    class MapeadorControladorCliente : MapeadorBaseControlador<ClienteDBModel, ClienteDTO>
    {
        public override ClienteDTO MapearT1T2(ClienteDBModel entrada)
        {
            return new ClienteDTO()
            {
                Id_cliente = entrada.Id_cliente,
                Direccion = entrada.Direccion,
                Correo1 = entrada.Correo1
            };
        }

        public override IEnumerable<ClienteDTO> MapearT1T2(IEnumerable<ClienteDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override ClienteDBModel MapearT2T1(ClienteDTO entrada)
        {
            return new ClienteDBModel()
            {
                Id_cliente = entrada.Id_cliente,
                Direccion = entrada.Direccion,
                Correo1 = entrada.Correo1

            };
        }

        public override IEnumerable<ClienteDBModel> MapearT2T1(IEnumerable<ClienteDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
