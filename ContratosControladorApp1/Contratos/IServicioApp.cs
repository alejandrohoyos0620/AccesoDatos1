using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
     public interface IServicioApp
    {
        bool RegistrarServicio(ServicioDTO servicio);
        ServicioDTO BuscarServicio(int id);
        bool EliminarServicio(int id);
        bool ActualizarServicio(ServicioDTO servicio);
        IEnumerable<ServicioDTO> ConsultaServicios();
    }
}
