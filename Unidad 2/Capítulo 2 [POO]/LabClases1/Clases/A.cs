using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace Clases
{
    public class A
    {
        private string nomInstancia = "N/A";

        public string NombreInstancia
        {
            get
            {
                return nomInstancia;
            }
            set
            {
                nomInstancia = value;
            }
        }

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1() {
            Console.WriteLine("Método M1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("Método M2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("Método M3 invocado");
        }


    }
}