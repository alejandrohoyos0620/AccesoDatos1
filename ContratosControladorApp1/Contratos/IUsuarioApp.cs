using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
    public interface IUsuarioApp
    {
        bool IngresarUsuario(UsuarioDTO usuario);
        UsuarioDTO BuscarUsuario(int id);
        bool EliminarUsuario(int id);
        bool ActualizarUsuario(UsuarioDTO usuario);
        IEnumerable<UsuarioDTO> ConsultaUsuarios();
    }
}
