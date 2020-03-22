using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
    public interface IMascota
    {
        bool RegistrarMascota(MascotaDBModel mascota);
        MascotaDBModel BuscarMascota(int id);
        bool EliminarMascota(int id);
        bool ActualizarMacota(MascotaDBModel mascota);
        IEnumerable<MascotaDBModel> ConsultaMascotas();
    }
}
