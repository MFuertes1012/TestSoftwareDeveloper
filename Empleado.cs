using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoftwareDeveloper
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
        {
            Id=id;
            Nombre=nombre;
            ApellidoPaterno=apellidoPaterno;
            ApellidoMaterno=apellidoMaterno;
            FechaNacimiento=fechaNacimiento;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
