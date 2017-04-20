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
    public class PersonasNego
    {
        PersonasRepo personasrepo = new PersonasRepo();

        public void GuardarPersonas(Persona persona)
        {
            personasrepo.GuardarPersona(persona);
        }

        public DataTable listarPersonas()
        {
            return personasrepo.listarPersonas();
        }

        public DataTable buscarPersona (int personaId)
        {
            return personasrepo.buscarPersona(personaId);
        }

    }
}
