using System;

namespace IterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("hello" + name);
                flag++;
            }
        }
        public static void Displayno(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static void Displaywhole(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + " ");
                flag++;
            } while (flag <= i);
        }
        public static int Returnfact(int k)
        {
            int fact = 1;
            for (int i= 1; i<= k;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void Displayeven(int no)
        {
            for(int j=1;j<=no;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.Write(j + "\t");
            }
        }
        public static string vowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'i':
                    result = "vowel";
                    break;
                case '1':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                default:
                    result = "invaild input";
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Greet("navya");
            //Displayno(100);
            //Displaywhole(40);
            // Displayeven(100);
            //Console.WriteLine(Returnfact(5));
            //Console.WriteLine(vowel('2'));
            //Console.WriteLine(vowel('e'));

            Console.ReadKey();
        }
    }
}
