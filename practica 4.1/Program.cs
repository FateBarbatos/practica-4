using System;

namespace practica_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            array1[3] = 8;
            array1[0] = 15;
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(i + " " + array1[i]);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }
            Console.WriteLine(" ");
            foreach (int row in array1) {
                Console.WriteLine(row);
            }

            Console.WriteLine(" ");
            string[] paises = new string[5] {"El Salvador","Mexico","Chile","Colombia","Venezuela"};
            foreach(string pai in paises)
            {
                Console.WriteLine(pai);
            }
        }
    }
}
