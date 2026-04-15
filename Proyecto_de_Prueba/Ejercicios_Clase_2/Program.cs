using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero entero");
            //String numero1String = ;
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("NUMERO INGRESADO = " + numero1);

            Console.WriteLine("ingrese el segundo numero entero");
            //String numero2String = ;
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("NUMERO INGRESADO = " + numero2);

            if (numero1 > numero2)
            {

                Console.WriteLine("el numero " + numero1 + " es mayor que " + numero2);

            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("el numero " + numero2 + " es mayor que " + numero1);

            }
            else
            {

                Console.WriteLine("LOS NUMEROS SON IGUALES");
            }



            if (numero1 % numero2 == 0)
            {
                Console.WriteLine("el primer numero es multiplo del segundo numero");

            }
            else {

                Console.WriteLine("el primer numero no es multiplo del segundo numero");
            }


            Console.ReadLine();

        }
    }

}
