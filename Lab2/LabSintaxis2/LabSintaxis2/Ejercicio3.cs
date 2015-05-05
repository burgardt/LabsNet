using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Ejercicio3
    {
        public void solucion() {
            int cantIteraciones = 5;
            string[] posiciones = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++) {
                Console.Write("Ingrese posicion " + (i + 1) + ": ");
                posiciones[i] = Console.ReadLine();
            }
            for (int i = cantIteraciones; i > 0 ; i--){
                Console.WriteLine("Posicion " + i + ": " + posiciones[i-1]);
            }
            Console.Read();
        }
    }
}
