using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Consulta
    {
        DateTime fecha;
        Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime Fecha 
        {
            get{ return this.fecha; }
        }

        public Paciente Paciente{
            get { return this.paciente; }
        }

        public override string ToString()
        {
            return $"{this.fecha.ToString()} se ha atendido a {this.paciente.NombreCompleto}"
        }
    }
