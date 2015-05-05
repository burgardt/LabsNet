using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 ejer1 = new Ejercicio1();
            Ejercicio2 ejer2 = new Ejercicio2();
            Ejercicio3 ejer3 = new Ejercicio3();
            Ejercicio4 ejer4 = new Ejercicio4();
            //ejer1.solucion();
            //ejer2.solucion();
            //ejer3.solucion();

            ejer4.primosGemelos();

            /*  Pasar mes como parámetro y recibir su nro.
            Console.Write("Ingrese nombre mes: ");
            string nombreMes = Console.ReadLine();
            Console.Write("El nro del mes es: " + ejer4.nroMes(nombreMes.ToLower()));
            Console.Read();
            */
        }
    }
}
