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
    public  class UsuarioRepositorio : IUsuario
    {
        public bool ActualizarUsuario(UsuarioDBModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDBModel BuscarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDBModel> ConsultaUsuarios()
        {

            using (petServicesEntities1 db = new petServicesEntities1())
            {
                IList<usuario> listadoUsuarioBD = db.usuarios.ToList();
                var lista = new MapeadoresRepositorioUsuario().MapearT1T2(listadoUsuarioBD).ToList();
                return lista;
            }
        }

        public bool EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool IngresarUsuario(UsuarioDBModel usuario)
        {
            try {
                usuario user = new MapeadoresRepositorioUsuario().MapearT2T1(usuario);
                using ( petServicesEntities1 db= new petServicesEntities1())
                {
                    db.usuarios.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch {
                return false;
            }
            
        }
    }
}
