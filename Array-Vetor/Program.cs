using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] veiculos = new string[3];
            veiculos[0] = "Fiat";
            veiculos[1] = "Gol";
            veiculos[2] = "Ferrari";

            int[] n = { 33, 55, 32, 43};

            int[] num = new int [3]{ 19, 02, 2004 };

            Console.WriteLine(veiculos[0]);
            Console.WriteLine(n[3]);
            Console.WriteLine(num[1]);  
            Console.ReadKey();
        }
    }
}
