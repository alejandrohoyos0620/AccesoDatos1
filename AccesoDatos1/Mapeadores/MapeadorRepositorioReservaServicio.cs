using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioReservaServicio : MapeadoresRepositorioDB<reservaServico, ReservaServicioDBModel>
    {
        public override ReservaServicioDBModel MapearT1T2(reservaServico entrada)
        {
            return new ReservaServicioDBModel()
            {
                Id_reservaServicio = entrada.id_reservaservicio,
                Id_mascota = entrada.id_mascota,
                Id_servicio = entrada.id_servicio
            };
        }

        public override IEnumerable<ReservaServicioDBModel> MapearT1T2(IEnumerable<reservaServico> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override reservaServico MapearT2T1(ReservaServicioDBModel entrada)
        {
            return new reservaServico()
            {
                id_reservaservicio = entrada.Id_reservaServicio,
                id_mascota = entrada.Id_mascota,
                id_servicio = entrada.Id_servicio
            };
        }

        public override IEnumerable<reservaServico> MapearT2T1(IEnumerable<ReservaServicioDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
