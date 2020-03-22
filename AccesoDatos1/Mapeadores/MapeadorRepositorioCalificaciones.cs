using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioCalificaciones : MapeadoresRepositorioDB<calificacione, CalificacionesDBModel>
    {
        public override CalificacionesDBModel MapearT1T2(calificacione entrada)
        {
            return new CalificacionesDBModel()
            {
                Id_calificacion = entrada.id_calificacion,
                Id_cliente = entrada.id_cliente,
                Id_servicio = entrada.id_servicio,
                calificacion = entrada.calificacion,
                comentario = entrada.comentario
            };
        }

        public override IEnumerable<CalificacionesDBModel> MapearT1T2(IEnumerable<calificacione> entrada)
        {
            foreach (var item in entrada)

            {
                yield return MapearT1T2(item);

            }
        }

        public override calificacione MapearT2T1(CalificacionesDBModel entrada)
        {
            return new calificacione()
            {
                id_calificacion = entrada.Id_calificacion,
                id_cliente = entrada.Id_cliente,
                id_servicio = entrada.Id_servicio,
                calificacion = entrada.calificacion,
                comentario = entrada.comentario
            };
        }

        public override IEnumerable<calificacione> MapearT2T1(IEnumerable<CalificacionesDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
