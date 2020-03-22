using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorServicio : MapeadorBaseControlador<ServicioDBModel, ServicioDTO>
    {
        public override ServicioDTO MapearT1T2(ServicioDBModel entrada)
        {
            return new ServicioDTO()
            {
                Servicio = entrada.Servicio,
                Nombre_servicio = entrada.Nombre_servicio,
                descripcion_servicio = entrada.descripcion_servicio,
                Imagen = entrada.Imagen
            };
        }

        public override IEnumerable<ServicioDTO> MapearT1T2(IEnumerable<ServicioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override ServicioDBModel MapearT2T1(ServicioDTO entrada)
        {
            return new ServicioDBModel()
            {
                Servicio = entrada.Servicio,
                Nombre_servicio = entrada.Nombre_servicio,
                descripcion_servicio = entrada.descripcion_servicio,
                Imagen = entrada.Imagen

            };
        }

        public override IEnumerable<ServicioDBModel> MapearT2T1(IEnumerable<ServicioDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
