using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Clase_2
{
    public class Stock : Pieza
    {
        public double Espesor { get; set; }

     public Stock(string nombre, string tipo, int cantidad, double espesor) 
        : base(nombre, tipo, cantidad)
        {
            this.Espesor = espesor;
            Console.WriteLine("RAMA1");
            Console.WriteLine("RAMA2");

        }

    }
}
