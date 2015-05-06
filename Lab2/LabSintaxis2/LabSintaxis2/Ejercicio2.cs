using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    public class Ejercicio2
    {
        public void solucion()
        {
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
                System.Console.WriteLine("Ingrese opción: 1. Mayúsculas, 2. Minúsculas, 3. Cantidad Caracteres");
                ConsoleKeyInfo opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("Op incorrecta");
                        Environment.Exit(0);
                        break;
                }
            }
            Console.Read();
        }
    }
}
