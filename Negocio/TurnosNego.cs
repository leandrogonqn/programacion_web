using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;
using System.Data;

namespace Negocio
{
    public class TurnosNego
    {
        TurnosRepo turnoRepo = new TurnosRepo();
        public void guadarTurnos (Turno turno)
        {
            turnoRepo.guardarTurno(turno);
        }
        public DataTable listarTurnos()
        {
            return turnoRepo.listarTurnos();
        }
        public DataTable CargarDropdown()
        {
            return turnoRepo.CargarDropdown();
        }

        public DataTable buscarTurnos(int turnosId)
        {
            return turnoRepo.buscarTurnos(turnosId);
        }

        public void modificarTurno(int turnosId, Turno t)
        {
            turnoRepo.ModificarTurno(turnosId, t);
        }
    }
}
