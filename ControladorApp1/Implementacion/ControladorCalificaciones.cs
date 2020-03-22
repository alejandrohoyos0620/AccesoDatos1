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
    public class ControladorCalificaciones : ICalificacionApp
    {
        ICalificaciones _respositorio;
        public ControladorCalificaciones(ICalificaciones calificacionesRep)
        {
            _respositorio = calificacionesRep;
        }
        public bool ActualizarCalificacion(CalificacionesDTO calificacion)
        {
            throw new NotImplementedException();
        }

        public CalificacionesDTO BuscarCalificacion(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalificacionesDTO> ConsultaCalificaciones()
        {
            MapeadorControladorCalificaciones mapeador = new MapeadorControladorCalificaciones();
            var ListaCalificacionesDBModel = _respositorio.ConsultaCalificaciones();
            IEnumerable<CalificacionesDTO> ListaCalificacionesDTO = mapeador.MapearT1T2(ListaCalificacionesDBModel);
            return ListaCalificacionesDTO;
        }

        public bool EliminarCalificacion(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarCalificacion(CalificacionesDTO calificacion)
        {
            MapeadorControladorCalificaciones mapeador = new MapeadorControladorCalificaciones();
            CalificacionesDBModel calificacionesDBModel = mapeador.MapearT2T1(calificacion);
            bool Respuesta = _respositorio.RegistrarCalificacion(calificacionesDBModel);
            return Respuesta;

        }
    }
}
