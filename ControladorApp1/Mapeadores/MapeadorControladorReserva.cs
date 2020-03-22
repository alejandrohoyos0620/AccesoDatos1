using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorReserva : MapeadorBaseControlador<ReservaDBModel, ReservaDTO>
    {
        public override ReservaDTO MapearT1T2(ReservaDBModel entrada)
        {
            return new ReservaDTO()
            {
                Id_reserva = entrada.Id_reserva,
                Id_reservacion = entrada.Id_reservacion,
                Id_cliente = entrada.Id_cliente,
                Estadoreserva = entrada.Estadoreserva,
                fecha = entrada.fecha,
                hora = entrada.hora,
                Factura = entrada.Factura,
                Tipopago = entrada.Tipopago,
                Total = entrada.Total
            };
        }

        public override IEnumerable<ReservaDTO> MapearT1T2(IEnumerable<ReservaDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override ReservaDBModel MapearT2T1(ReservaDTO entrada)
        {
            return new ReservaDBModel()
            {
                Id_reserva = entrada.Id_reserva,
                Id_reservacion = entrada.Id_reservacion,
                Id_cliente = entrada.Id_cliente,
                Estadoreserva = entrada.Estadoreserva,
                fecha = entrada.fecha,
                hora = entrada.hora,
                Factura = entrada.Factura,
                Tipopago = entrada.Tipopago,
                Total = entrada.Total
            };
        }

        public override IEnumerable<ReservaDBModel> MapearT2T1(IEnumerable<ReservaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
