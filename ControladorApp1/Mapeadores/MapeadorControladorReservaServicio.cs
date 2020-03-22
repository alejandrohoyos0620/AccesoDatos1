using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorReservaServicio : MapeadorBaseControlador<ReservaServicioDBModel, ReservaServicioDTO>
    {
        public override ReservaServicioDTO MapearT1T2(ReservaServicioDBModel entrada)
        {
            return new ReservaServicioDTO()
            {
                Id_reservaServicio = entrada.Id_reservaServicio,
                Id_mascota = entrada.Id_mascota,
                Id_servicio = entrada.Id_servicio

            };
        }

        public override IEnumerable<ReservaServicioDTO> MapearT1T2(IEnumerable<ReservaServicioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override ReservaServicioDBModel MapearT2T1(ReservaServicioDTO entrada)
        {
            return new ReservaServicioDBModel()
            {

                Id_reservaServicio = entrada.Id_reservaServicio,
                Id_mascota = entrada.Id_mascota,
                Id_servicio = entrada.Id_servicio
            };
        }

        public override IEnumerable<ReservaServicioDBModel> MapearT2T1(IEnumerable<ReservaServicioDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
