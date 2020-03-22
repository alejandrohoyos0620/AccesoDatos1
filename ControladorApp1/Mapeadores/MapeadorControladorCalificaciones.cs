using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorCalificaciones : MapeadorBaseControlador<CalificacionesDBModel, CalificacionesDTO>
    {
        public override CalificacionesDTO MapearT1T2(CalificacionesDBModel entrada)
        {
            return new CalificacionesDTO()
            {
                Id_calificacion = entrada.Id_calificacion,
                Id_cliente = entrada.Id_cliente,
                Id_servicio = entrada.Id_servicio,
                calificacion = entrada.calificacion,
                comentario = entrada.comentario
            };

        }

        public override IEnumerable<CalificacionesDTO> MapearT1T2(IEnumerable<CalificacionesDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override CalificacionesDBModel MapearT2T1(CalificacionesDTO entrada)
        {
            return new CalificacionesDBModel()
            {
                Id_calificacion = entrada.Id_calificacion,
                Id_cliente = entrada.Id_cliente,
                Id_servicio = entrada.Id_servicio,
                calificacion = entrada.calificacion,
                comentario = entrada.comentario

            };
        }

        public override IEnumerable<CalificacionesDBModel> MapearT2T1(IEnumerable<CalificacionesDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
