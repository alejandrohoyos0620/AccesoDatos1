using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    class MapeadoresRepositorioUsuario : MapeadoresRepositorioDB<usuario, UsuarioDBModel>
    {
        public override UsuarioDBModel MapearT1T2(usuario entrada)
        {
            return new UsuarioDBModel()
                {
                Id_usuario=entrada.id_usuario,
                Nombre= entrada.nombre,
                Contraseña=entrada.contraseña
            };
        }

        public override IEnumerable<UsuarioDBModel> MapearT1T2(IEnumerable<usuario> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override usuario MapearT2T1(UsuarioDBModel entrada)
        {
            return new usuario()
            {
                id_usuario = entrada.Id_usuario,
                nombre = entrada.Nombre,
                contraseña = entrada.Contraseña
            };
        }

        public override IEnumerable<usuario> MapearT2T1(IEnumerable<UsuarioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
