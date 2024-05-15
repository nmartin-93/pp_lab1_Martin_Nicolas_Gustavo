using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public abstract class Persona
    {
        private string apellido;
        protected string barrioRecidencia;
        private DateTime nacimiento;
        private string nombre;


        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, string barrioRecidencia, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
        }

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get{ return $"{this.apellido},  {this.nombre}"; }
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }

        public void FichaPersonal()
        {
            Console.WriteLine($"Nombre Completo: {this.NombreCompleto}\nEdad: {this.Edad}");
            if(barrioRecidencia != null)
            {
                Console.WriteLine("Domicilio: " + this.barrioRecidencia);
            }
        }

        internal abstract string fichaExtra();


    }
}
