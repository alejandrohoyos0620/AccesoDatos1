using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Mapeadores
{
    public class MapeadorRepositorioMascota : MapeadoresRepositorioDB<mascota, MascotaDBModel>
    {
        public override MascotaDBModel MapearT1T2(mascota entrada)
        {
            return new MascotaDBModel()
            {
                Id_mascota = entrada.id_mascota,
                Id_dueño = entrada.id_dueño,
                Nombre_mascota = entrada.nombre_mascota,
                Raza = entrada.raza,
                Pdf_canet = entrada.pdf_canet
            };
        }

        public override IEnumerable<MascotaDBModel> MapearT1T2(IEnumerable<mascota> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);

            }
        }

        public override mascota MapearT2T1(MascotaDBModel entrada)
        {
            return new mascota()
            {
                id_mascota = entrada.Id_mascota,
                id_dueño = entrada.Id_dueño,
                nombre_mascota = entrada.Nombre_mascota,
                raza = entrada.Raza,
                pdf_canet = entrada.Pdf_canet
            };
        }

        public override IEnumerable<mascota> MapearT2T1(IEnumerable<MascotaDBModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
