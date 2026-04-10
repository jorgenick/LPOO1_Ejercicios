using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_de_Prueba
{
    class Program
    {



        static void Main(string[] args)
        {

            Console.WriteLine("este es mi primer proyecto de prueba");
            Console.WriteLine("estamos probando el puente con al maquina virtual");
            Console.WriteLine("probando la maquina virtual");

            Console.WriteLine("ingrese 1er numero");

            String numero1 = Console.ReadLine();
            int numero1i = int.Parse(numero1);

            Console.WriteLine("ingrese 2do numero");

            String numero2 = Console.ReadLine();
            int numero2i = int.Parse(numero2);

            Console.WriteLine("LA SUMA ES IGUAL A " + SumarNumeros(numero1i, numero2i));
            Console.ReadKey();
        }

        public static int SumarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;

            return resultado;

        }

    }
}
