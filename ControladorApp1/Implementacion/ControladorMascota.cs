using ContratoAccesoDatos1.Contratos;
using ContratoAccesoDatos1.RkModel;
using ContratosControladorApp1.Contratos;
using ContratosControladorApp1.DTO;
using ControladorApp1.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp1.Implementacion
{
    public class ControladorMascota : IMascotaApp
    {
        IMascota _repositorio;
        public ControladorMascota(IMascota mascotaRep)
        {
            _repositorio = mascotaRep;
        }
        public bool ActualizarMacota(MascotaDTO mascota)
        {
            throw new NotImplementedException();
        }

        public MascotaDTO BuscarMascota(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MascotaDTO> ConsultaMascotas()
        {
            MapeadorControladorMascota mapeador = new MapeadorControladorMascota();
            var ListaMascotaDBModel = _repositorio.ConsultaMascotas();
            IEnumerable<MascotaDTO> ListaMascotasDTO = mapeador.MapearT1T2(ListaMascotaDBModel);
            return ListaMascotasDTO;
        }

        public bool EliminarMascota(int id)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarMascota(MascotaDTO mascota)
        {
            MapeadorControladorMascota mapeador = new MapeadorControladorMascota();
            MascotaDBModel mascotaDBModel = mapeador.MapearT2T1(mascota);
            bool respuesta = _repositorio.RegistrarMascota(mascotaDBModel);
            return respuesta;
        }
    }
}
