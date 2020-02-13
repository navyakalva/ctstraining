using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] name = new int [3][];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter size");
                int size = int.Parse(Console.ReadLine());
                name[i] = new int[size];

            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < name[row].Length; col++)
                {
                    name[row][col] = Console.ReadLine();
                }
            }
        }
    }
}
