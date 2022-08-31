using System;
using System.Collections;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Capacidad: {0}", lista.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                lista.Add("Dato " + 1);
            }
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Capacidad: {0}", lista.Capacity);
            Console.WriteLine();

            for (int i = 10; i < 33; i++)
            {
                lista.Add("Dato " + 1);
            }
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Capacidad: {0}", lista.Capacity);
            Console.WriteLine();

            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            Console.WriteLine(" ============ Eliminar rango =============");
            lista.RemoveRange(5, 4);
            lista.RemoveRange(15, 6);

            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            lista.Insert(11, "Elemento nuevo");

            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            lista.Clear();
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Capacidad: {0}", lista.Capacity);
        }
    }
}
