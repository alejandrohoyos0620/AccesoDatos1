using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
    public interface IUsuario
    {
        bool IngresarUsuario(UsuarioDBModel usuario );
        UsuarioDBModel BuscarUsuario(int id);
        bool EliminarUsuario( int id);
        bool ActualizarUsuario(UsuarioDBModel usuario);
        IEnumerable<UsuarioDBModel> ConsultaUsuarios();
    }
}
