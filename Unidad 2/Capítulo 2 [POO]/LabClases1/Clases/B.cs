using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace Clases
{
    public class B : A
    {

        public B() {
            A insA = new A("Instancia de B");       //CONSULTAR ESTA PARTE
        }

        public void M4() {
            Console.WriteLine("Metodo del hijo Invocado");
        }
    }
}