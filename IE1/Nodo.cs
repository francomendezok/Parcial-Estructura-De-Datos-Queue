using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    public class Paciente
    {
        public string dni;
        public string apellido;
        public string nombre;
        public string especialidad;
        public Paciente siguiente;

        public Paciente(string dni, string apellido, string nombre, string especialidad)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.especialidad = especialidad;
            this.siguiente = null;
        }
    }
}
