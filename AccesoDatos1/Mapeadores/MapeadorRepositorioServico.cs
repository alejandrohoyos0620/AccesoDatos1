using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioServico : MapeadoresRepositorioDB<servicio, ServicioDBModel>
    {
        public override ServicioDBModel MapearT1T2(servicio entrada)
        {
            return new ServicioDBModel()
            {
                Servicio = entrada.id_servicio,
                Nombre_servicio = entrada.nombre_servicio,
                descripcion_servicio = entrada.descripcion_servicio,
                Imagen = entrada.imagen_servicio

            };
        }

        public override IEnumerable<ServicioDBModel> MapearT1T2(IEnumerable<servicio> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);

            }
        }

        public override servicio MapearT2T1(ServicioDBModel entrada)
        {
            return new servicio()
            {
                id_servicio = entrada.Servicio,
                nombre_servicio = entrada.Nombre_servicio,
                descripcion_servicio = entrada.descripcion_servicio,
                imagen_servicio = entrada.Imagen

            };
        }

        public override IEnumerable<servicio> MapearT2T1(IEnumerable<ServicioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);

            }
        }
    }
}
