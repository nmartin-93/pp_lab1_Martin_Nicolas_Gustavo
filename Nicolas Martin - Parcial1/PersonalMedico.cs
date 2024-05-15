using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esRecidente;

        public PersonalMedico(string nombre,string apellido, DateTime nacimiento, bool esRecidente)
            :base(nombre, apellido, nacimiento)
        {
            this.esRecidente = esRecidente;
            this.consultas = new List<Consulta>();
        }

        internal override string fichaExtra()
        {
            String ficha;
            if (!esRecidente)
            {
                ficha = "¿Finalizo residencia? NO"; 
            }
            else
            {
                ficha = "¿Finalizo residencia? SI";
            }
            for (int i = 0; i < consultas.Count; i++)
            {
                ficha += consultas[i].ToString();
            }
            return ficha;
        }

        public static Consulta operator +(PersonalMedico medico,Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            medico.consultas.Add(consulta);
            return consulta;
        } 
    }
}
