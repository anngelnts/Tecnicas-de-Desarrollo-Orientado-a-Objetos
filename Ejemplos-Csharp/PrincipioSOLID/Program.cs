using PrincipioSOLID.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadosServicio empleados = new EmpleadosServicio();
            //instanciar
            Empleado programador = new Programador { Nombre = "Anngel", Sueldo = 2000 };
            Empleado gerente = new Gerente { Nombre = "Luis", Sueldo = 2000 };
            //agregar datos
            empleados.Empleados.Add(programador);
            empleados.Empleados.Add(gerente);
            //calcular bono
            empleados.CalcularBonos();
            Console.ReadLine();
        }
    }
}
