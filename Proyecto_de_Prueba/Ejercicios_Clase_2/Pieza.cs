using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Clase_2
{
    public class Pieza
    {
        private static int next = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }



        public Pieza(string nombre, string tipo, int cantidad)
        {
            this.Id = next;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            next++;
        }

    }
}
