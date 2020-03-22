using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
    public interface IMascotaApp
    {
        bool RegistrarMascota(MascotaDTO mascota);
        MascotaDTO BuscarMascota(int id);
        bool EliminarMascota(int id);
        bool ActualizarMacota(MascotaDTO mascota);
        IEnumerable<MascotaDTO> ConsultaMascotas();
    }
}
