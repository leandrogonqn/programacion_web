using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        private int personaId;
        private DateTime registroTurno;
        private DateTime fechaTurno;
        private String motivoTurno;
        private String tareas;
      
        public DateTime RegistroTurno
        {
            get
            {
                return registroTurno;
            }

            set
            {
                registroTurno = value;
            }
        }

        public DateTime FechaTurno
        {
            get
            {
                return fechaTurno;
            }

            set
            {
                fechaTurno = value;
            }
        }

        public string MotivoTurno
        {
            get
            {
                return motivoTurno;
            }

            set
            {
                motivoTurno = value;
            }
        }

        public string Tareas
        {
            get
            {
                return tareas;
            }

            set
            {
                tareas = value;
            }
        }

        public int PersonaId
        {
            get
            {
                return personaId;
            }

            set
            {
                personaId = value;
            }
        }
    }
}
