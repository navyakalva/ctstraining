using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            
            for(int col=0;col<3;col++)
            {
                for(int row=0;row<5;row++)
                {
                    marks[row, col] = int.Parse(Console.ReadLine());
                }
            }//reading
            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row< 5; row++)
                {
                    Console.Write(" "+ marks[row, col]);
                }
                
            }//display
            for (int col = 0; col < 3; col++)
            {
                int topscore=0;
                for (int row = 0; row < 5; row++)
                {
                    if (row == 0)
                        topscore = marks[row, col];
                    else
                    {
                        if (marks[row, col] >topscore)
                            topscore = marks[row, col];
                    }
                }
                Console.WriteLine("high sub" + (col + 1) + "is" + topscore);

            }
            Console.ReadKey();
        }
    }
}
