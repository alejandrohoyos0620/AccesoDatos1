using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorUsuario : MapeadorBaseControlador<UsuarioDBModel, UsuarioDTO>
    {
        public override UsuarioDTO MapearT1T2(UsuarioDBModel entrada)
        {
            return new UsuarioDTO()
            {
                Id_usuario = entrada.Id_usuario,
                Nombre = entrada.Nombre,
                Contraseña = entrada.Contraseña


            };
        }

        public override IEnumerable<UsuarioDTO> MapearT1T2(IEnumerable<UsuarioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override UsuarioDBModel MapearT2T1(UsuarioDTO entrada)
        {
            return new UsuarioDBModel()
            {
                Id_usuario = entrada.Id_usuario,
                Nombre = entrada.Nombre,
                Contraseña = entrada.Contraseña
            };
        }

        public override IEnumerable<UsuarioDBModel> MapearT2T1(IEnumerable<UsuarioDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
