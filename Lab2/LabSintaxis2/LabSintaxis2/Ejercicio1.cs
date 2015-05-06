using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Ejercicio1
    {
        public void solucion(){
            string inputTexto;
            Console.Write("Ingrese un texto: ");
            inputTexto = Console.ReadLine();
            if (string.IsNullOrEmpty(inputTexto))
            {
                System.Console.WriteLine("No ingresó texto");
                Environment.Exit(0);
            }
            else 
            {
                System.Console.WriteLine("Ingrese opción: 1. Mayúsculas, 2. Minúsculas, 3. Cantidad Caracteres" );
                ConsoleKeyInfo opcion = Console.ReadKey();            
                if (opcion.Key == ConsoleKey.D1)
                {
                    System.Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    System.Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    System.Console.WriteLine(inputTexto.Length);
                }
                else 
                {
                    System.Console.WriteLine("Op incorrecta");
                    Environment.Exit(0);
                }
            }
            Console.Read();
        }
        
    }
}
