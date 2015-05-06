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

            int op1, op2;
            op1 = op2 = 0;
            Console.WriteLine("1: Estructuras de Decisión, 2: Estructuras de Decisión (bis), 3: Estructuras de Iteración, 4: Ejercicios para pensar.");
            op1 = Convert.ToInt32(Console.ReadLine());

            switch (op1)
            {
                case 1:
                    ejer1.solucion();
                    break;
                case 2:
                    ejer2.solucion();
                    break;
                case 3:
                    ejer3.solucion();
                    break;
                case 4:
                    Console.WriteLine("1: Suma dos numeros, 2: Año Bisiesto, 3: Serie Fibonacci, 4: Números Pares, 5: Número Mes, 6: Primos Gemelos, 7: Ingreso Clave, 8: Triangulo");
                    op2 = Convert.ToInt32(Console.ReadLine());
                    switch (op2)
                    {
                        case 1:
                            ejer4.sumaDosNumeros();
                            break;
                        case 2:
                            ejer4.anoBisiesto();
                            break;
                        case 3:
                            ejer4.serieFibonacci();
                            break;
                        case 4:
                            ejer4.nrosPares();
                            break;
                        case 5:
                            Console.Write("Ingrese nombre mes: ");
                            string nombreMes = Console.ReadLine();
                            Console.Write("El nro del mes es: " + ejer4.nroMes(nombreMes.ToLower()));
                            Console.Read();
                            break;
                        case 6:
                            ejer4.primosGemelos();
                            break;
                        case 7:
                            ejer4.ingresoClave();
                            break;
                        case 8:
                            ejer4.triangulo();
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }

                    break;

                default:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
