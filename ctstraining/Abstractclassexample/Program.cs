using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.cricket player details\n2.hockey player details\n");
            Console.WriteLine("enter menu");
            int menu = int.Parse(Console.ReadLine());
            Cricketplayer cp = new Cricketplayer("navya","chennai",7,6,8);
            Hockeyplayer hp = new Hockeyplayer("mani","hyd",1,"captain",3);
            if (menu == 1)
                cp.Displayplayerstatistic();
            else if (menu == 2)
                hp.Displayplayerstatistic();
            else
                Console.WriteLine("invalid");
            Console.ReadKey();
        }
    }
}
