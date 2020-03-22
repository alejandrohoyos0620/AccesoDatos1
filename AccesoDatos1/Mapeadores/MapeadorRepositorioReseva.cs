using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioReseva : MapeadoresRepositorioDB<reserva, ReservaDBModel>
    {
        public override ReservaDBModel MapearT1T2(reserva entrada)
        {
            return new ReservaDBModel()
            {
                Id_reserva = entrada.id_reservacion,
                Id_cliente = entrada.id_cliente,
                Id_reservacion = entrada.id_reservaservicio,
                hora = entrada.hora,
                fecha = entrada.fecha,
                Estadoreserva = entrada.estadoreserva,
                Total = entrada.total,
                Factura = entrada.factura,
                Tipopago = entrada.tipopago

            };
        }

        public override IEnumerable<ReservaDBModel> MapearT1T2(IEnumerable<reserva> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override reserva MapearT2T1(ReservaDBModel entrada)
        {
            return new reserva()
            {
                id_reservacion = entrada.Id_reserva,
                id_cliente = entrada.Id_cliente,
                id_reservaservicio = entrada.Id_reservacion,
                hora = entrada.hora,
                fecha = entrada.fecha,
                estadoreserva = entrada.Estadoreserva,
                total = entrada.Total,
                factura = entrada.Factura,
                tipopago = entrada.Tipopago

            };
        }

        public override IEnumerable<reserva> MapearT2T1(IEnumerable<ReservaDBModel> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
