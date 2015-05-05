using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LabSintaxis2
{
    class Ejercicio4
    {
        public void sumaDosNumeros() {
            int nro1, nro2;
            Console.Write("Ingrese 1er nro: ");
            nro1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese 2do nro: ");
            nro2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("El resultado de la suma de " + nro1 + " y " + nro2 + " es " + (nro1+nro2) + ".");
        }

        public void anoBisiesto() {
            Console.Write("Ingrese año: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            if ((((ano % 4) == 0) & !((ano % 100) == 0)) | (((ano % 100) == 0) & ((ano % 400) == 0)))
            {
                Console.Write("Biciesto");
            }
            else
            {
                Console.Write("NO biciesto");
            }
            Console.Read();
        }

        public void serieFibonacci() {
            Console.Write("Ingrese limite (cant de nros de la serie que se van a generar): ");
            int lim = Convert.ToInt32(Console.ReadLine());
            int[] fibo = new int[lim];
            fibo[0] = fibo[1] = 1;
            Console.Write(fibo[0] + ", ");
            Console.Write(fibo[1] + ", ");
            for (int i = 2; i <= (lim - 1);i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
                if (i == (lim - 1)) {
                    Console.Write(fibo[i]);
                    continue;
                }
                Console.Write(fibo[i] + ", ");
            }
            Console.Read();
        }

        public void nrosPares() {
            for (int i = 1; i <= 100;i++)
            {
                if ((i % 2) == 0) { 
                    if (i == 100) {
                        Console.Write(i);
                        continue;
                    }
                    Console.Write(i + ", ");
                }
            }
            Console.Read();
        }

        public int nroMes(string mes) {
            int nroDelMes = 0;
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            for (int i = 1; i <= 12; i++) {
                if (formatoFecha.GetMonthName(i) == mes) {
                    nroDelMes = i;
                }
            }
            if (nroDelMes == 0) {
                Environment.Exit(0);
            }
            
            return nroDelMes;
        }

        public void primosGemelos() {
            int p, i, suma;
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            suma = 0;
            i = 2;
            while(suma <= n)
            {
                if (esPrimo(i))
                {
                    p = i;

                    if (esPrimo(p + 2))
                    {
                        Console.WriteLine("(" + p + "; " + (p+2) + ")");
                        suma++;
                    }
                    
                }
                i++;
            }
            Console.Read();
        }

        private bool esPrimo(int p)
        {
            bool primo = true;
            for (int i = 2; i <= p; i++)
            {
                if ((p % i == 0) & (i != p))
                {
                    primo = false;
                }
            }
            return primo;
        }
    }
}
