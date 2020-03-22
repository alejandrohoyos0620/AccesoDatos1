using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioCliente : MapeadoresRepositorioDB<cliente, ClienteDBModel>
    {
        public override ClienteDBModel MapearT1T2(cliente entrada)
        {
            return new ClienteDBModel()
            {
                Id_cliente = entrada.id_cliente,
                Correo1 = entrada.correo,
                Direccion = entrada.direccion
            };
        }

        public override IEnumerable<ClienteDBModel> MapearT1T2(IEnumerable<cliente> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override cliente MapearT2T1(ClienteDBModel entrada)
        {
            return new cliente()
            {
                id_cliente = entrada.Id_cliente,
                correo = entrada.Correo1,
                direccion = entrada.Direccion
            };
        }


        public override IEnumerable<cliente> MapearT2T1(IEnumerable<ClienteDBModel> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearT2T1(item);
                        
            }    
        }
    }
}
