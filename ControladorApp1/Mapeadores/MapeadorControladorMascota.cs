using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Mapeadores
{
    public class MapeadorControladorMascota : MapeadorBaseControlador<MascotaDBModel, MascotaDTO>
    {
        public override MascotaDTO MapearT1T2(MascotaDBModel entrada)
        {
            return new MascotaDTO()
            {
                Id_mascota = entrada.Id_mascota,
                Id_dueño = entrada.Id_dueño,
                Nombre_mascota = entrada.Nombre_mascota,
                Raza = entrada.Raza,
                Pdf_canet = entrada.Pdf_canet
            };
        }

        public override IEnumerable<MascotaDTO> MapearT1T2(IEnumerable<MascotaDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override MascotaDBModel MapearT2T1(MascotaDTO entrada)
        {
            return new MascotaDBModel()
            {
                Id_mascota = entrada.Id_mascota,
                Id_dueño = entrada.Id_dueño,
                Nombre_mascota = entrada.Nombre_mascota,
                Raza = entrada.Raza,
                Pdf_canet = entrada.Pdf_canet
            };
        
        }

        public override IEnumerable<MascotaDBModel> MapearT2T1(IEnumerable<MascotaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
