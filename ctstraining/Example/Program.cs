using System;

namespace Example
{
    class Program
    {
        public static void  Selectoption(int n)

        { 
            Console.WriteLine("enter choice");
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case '1':
                    
                        if (n % 2 == 0)
                            Console.WriteLine("even");
                        else
                            Console.WriteLine("odd");
                  
                        break;
                    
                case '2':
                     
                        int i = 1;
                        for(;i<=10;i++)
                        {
                            Console.WriteLine(i + " ");
                        }
            
                    break;

                case '3':
                     
                    
                        
                        for(i=1;i<=10;i++)
                        {
                        int j;
                        j = n * i;


                        Console.WriteLine(n + "*" + i + "=" + j);                                                                                                             )
                        }
            break;
             
            case '4':
            break;





            }
        }


        static void Main(string[] args)
        {
           
            Console.WriteLine("enter no");
            
            Console.WriteLine("1.even odd");
            Console.WriteLine("2.natural no");
            Console.WriteLine("3.table");
            Console.WriteLine("4.exit");
        int n = int.Parse(Console.ReadLine());
        Selectoption(n);
        Console.ReadKey();
            


        }
    }
}
