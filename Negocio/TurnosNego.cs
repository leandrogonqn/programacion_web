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
        TurnosRepo turnorepo = new TurnosRepo();
        public void guadarTurnos (Turno turno)
        {
            turnorepo.guardarTurno(turno);
        }
        public DataTable listarTurnos()
        {
            return turnorepo.listarTurnos();
        }
        public DataTable CargarDropdown()
        {
            return turnorepo.CargarDropdown();
        }
    }
}
