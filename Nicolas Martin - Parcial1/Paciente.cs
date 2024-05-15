using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Paciente : Persona
    {
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string domicilio) 
            :base ( nombre, apellido, nacimiento)
        {
        }

        public string Diagnostico { 
            get { return this.diagnostico; } 
            set { this.diagnostico = value; } 
        }

        internal override string fichaExtra()
        {
            return $"Recide en: {this.barrioRecidencia}\n{this.diagnostico}";
        }

    }
}
