using System;
using System.Collections.Generic;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = null;
            int[] arreglo = new int[0];
            Console.WriteLine("Write numbers (if you want to get out of here, type \"Exit\"):");
            while (j != "Exit")
            {                
                j = Console.ReadLine();
                int i;
                if(j == "Exit")
                {
                    break;
                }
                if(int.TryParse(j, out i) == false)
                {
                    Console.WriteLine("You didn't write a number; try again:");
                    continue;
                }
                i = arreglo.Length;
                int[] backup = new int[i];
                Array.Copy(arreglo, backup, i);
                arreglo = new int[i + 1];
                arreglo[i] = int.Parse(j);
                Array.Copy(backup, arreglo, i);
                
            }
            int suma = 0;
            Console.WriteLine("The numbers that you wrote:");
            foreach (int i in arreglo)
            {                
                suma = suma + i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"The sum is equal to: {suma}");
        }
    }
}
