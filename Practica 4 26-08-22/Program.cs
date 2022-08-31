using System;

namespace Practica_4_26_08_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            array1[2] = 8;
            array1[0] = 15;

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(i + " " + array1[i]);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i * 4;
            }

            foreach (int row in array1)
            {
                Console.WriteLine(row);
            }

            string[] paises = new string[5] { "El Salvador", "Mexico", "Chile", "Colombia", "Venezuela" };
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }
        }
    }
}
