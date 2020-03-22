using AccesoDatos1.Mapeadores;
using AccesoDatos1.Modelo;
using ContratoAccesoDatos1.Contratos;
using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos1.Implementacion
{

    public class MascotaRepositorio : IMascota
    {
        public bool ActualizarMacota(MascotaDBModel mascota)
        {
            throw new NotImplementedException();
        }

        public MascotaDBModel BuscarMascota(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MascotaDBModel> ConsultaMascotas()
        {

            using(petServicesEntities1 db= new petServicesEntities1())
            {
                IList<mascota> listaMascotasdb = db.mascotas.ToList();
                var lista = new MapeadorRepositorioMascota().MapearT1T2(listaMascotasdb).ToList();
                return lista;
            }
        }

        public bool EliminarMascota(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarMascota(MascotaDBModel mascota)
        {

            try
            {
                mascota mascota1 = new MapeadorRepositorioMascota().MapearT2T1(mascota);
                using (petServicesEntities1 db = new petServicesEntities1())
                {
                    db.mascotas.Add(mascota1);
                    db.SaveChanges();
                    return true;
                }


            }
            catch
            {
                return false;

            }
        }
    }
}
