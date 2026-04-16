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
            //Console.WriteLine("ingrese el primer numero entero");
            ////String numero1String = ;
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("NUMERO INGRESADO = " + numero1);

            //Console.WriteLine("ingrese el segundo numero entero");
            ////String numero2String = ;
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("NUMERO INGRESADO = " + numero2);

            //if (numero1 > numero2)
            //{

            //    Console.WriteLine("el numero " + numero1 + " es mayor que " + numero2);

            //}
            //else if (numero2 > numero1)
            //{
            //    Console.WriteLine("el numero " + numero2 + " es mayor que " + numero1);

            //}
            //else
            //{

            //    Console.WriteLine("LOS NUMEROS SON IGUALES");
            //}



            //if (numero1 % numero2 == 0)
            //{
            //    Console.WriteLine("el primer numero es multiplo del segundo numero");

            //}
            //else
            //{

            //    Console.WriteLine("el primer numero no es multiplo del segundo numero");
            //}


            //Console.ReadLine();


            Herramientas h = new Herramientas();
            h.Ingreso_de_Numeros();


        }
    }

    class Herramientas
    {

        public void Ingreso_de_Numeros()
        {
            Console.WriteLine("ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("numeros ingresados: \n" + "Numero 1 : " + numero1 + "\nNumero 2 :" + numero2);
            Console.ReadLine();

            int numeroMayor = CompararNumeros(numero1, numero2);
            DeterminarMultiplos(numero1, numero2);
            Console.ReadLine();
        }

        public int CompararNumeros(int numero1, int numero2)
        {
            int numeroMayor;
            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero ingresado es mayor que el segundo numero");
                numeroMayor = numero1;
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("el segundo numero ingresado en mayor que el primer numero");
                numeroMayor = numero2;
            }
            else
            {
                Console.WriteLine("los numeros ingresados son iguales");
                numeroMayor = 0;
            }

            return numeroMayor;
        }

        public void DeterminarMultiplos(int numero1, int numero2)
        {
            if (numero1 % numero2 == 0)
            {
                Console.WriteLine("el primer numero ES multiplo del segundo numero");
            }
            else
            {
                Console.WriteLine("el primer numero NO es multiplo del segundo");
            }

        }

    }

}
