using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
                al.Add(5);
                al.Add("navi");
                al.Add(2.11);
                 al.Add('a');
                al.Remove('a');
                      foreach (var x in al)
                    Console.WriteLine(x);

            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("navya");
            qlist.Enqueue('w');
            qlist.Dequeue();
           foreach (var e in qlist)
                Console.WriteLine(e);


            
          Stack slist = new Stack();
            slist.Push(23);
            slist.Push("navya");
            slist.Push("123.3");
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);

            Hashtable ht = new Hashtable();
            ht.Add(1, "cts");
            ht.Add('a', 1000);
            ht.Add("t1", 30);
            foreach(var h in ht.Keys)
            {
                Console.WriteLine(h);
                Console.WriteLine(ht[h]);
            }

            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');
            list.Add(34);
            foreach (int v in list)
                Console.WriteLine(v);

            HashSet<int> hs = new HashSet<int>();
            hs.Add(100);
            hs.Add(32);
            hs.Add(23);
            hs.Add(100);
            foreach (int val in hs)
                Console.WriteLine(val);


            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("anu");
            gqlist.Enqueue("navya");
            gqlist.Enqueue("ooh");
           Console.WriteLine( gqlist.Dequeue());//anu will be dispalyed
            foreach (var e in gqlist)
                Console.WriteLine(e);

            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(67.45f);
            gslist.Push(123.3f);
            Console.WriteLine(gslist.Pop());//lifo
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);

            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "raj");
            dt.Add(2, "anil");
            dt.Add(3, "navya");
            foreach(KeyValuePair<int,string>k1 in dt)
            {
                Console.WriteLine(k1.Key);
                Console.WriteLine(k1.Value);

            }

                



            Console.ReadKey();

        }
    }
}
