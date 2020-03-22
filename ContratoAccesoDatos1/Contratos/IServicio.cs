using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
     public interface IServicio
    {
        bool RegistrarServicio(ServicioDBModel servicio);
        ServicioDBModel BuscarServicio(int id);
        bool EliminarServicio(int id);
        bool ActualizarServicio(ServicioDBModel servicio);
        IEnumerable<ServicioDBModel> ConsultaServicios();
    }

}
