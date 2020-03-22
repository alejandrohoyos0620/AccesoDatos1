using ContratoAccesoDatos1.Contratos;
using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.Contratos;
using ContratosControladorApp1.DTO;
using ControladorApp1.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Implementacion
{
    public class ControladorUsuario : IUsuarioApp

    {
        IUsuario _repositorio;
        public ControladorUsuario(IUsuario _UsuarioRep)
        {
            this._repositorio = _UsuarioRep;
        }
        public bool ActualizarUsuario(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO BuscarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDTO> ConsultaUsuarios()
        {
            MapeadorControladorUsuario mapeador = new MapeadorControladorUsuario();
            var listaDBModel = _repositorio.ConsultaUsuarios();
            IEnumerable<UsuarioDTO> lista = mapeador.MapearT1T2(listaDBModel);
            return lista;
        }

        public bool EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool IngresarUsuario(UsuarioDTO usuario)
        {
            MapeadorControladorUsuario mapeador = new MapeadorControladorUsuario();
            UsuarioDBModel  user = mapeador.MapearT2T1(usuario);
            bool respuesta = _repositorio.IngresarUsuario(user);
            return respuesta;
            
        }
    }
}
