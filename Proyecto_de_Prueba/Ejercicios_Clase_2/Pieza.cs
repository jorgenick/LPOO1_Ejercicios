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

        private static List<int> listaNumeros = new List<int> {1,2,3,4,5,6,7,8,9,10 };

        public Pieza(string nombre, string tipo, int cantidad)
        {
            this.Id = next;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            next++;
        }

        public void MostrarListaNumerica() {

            Console.WriteLine("-----------LISTA NUMERICA DE PRUEBA---------");
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LISTA FILTRADA USANDO LINQ y WHERE ");
            var listaAlternativa = listaNumeros.Where(rango => rango > 5).ToList();


            var variable = listaNumeros.FirstOrDefault();

            foreach (var item in listaAlternativa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("USANDO FIRST ");

            var numero = listaNumeros.FirstOrDefault(n=>n==5);
            Console.WriteLine(numero);
        }

    }
}
