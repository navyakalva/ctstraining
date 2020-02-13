using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\Navya");
            di.Create();
            di.CreateSubdirectory("mydir");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("************************************");
            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            //FileStream fs = new FileStream(@"E:\Navya\mydir\a.txt", FileMode.OpenOrCreate, FileAccess.Write);//writing data to file
            // StreamWriter sw = new StreamWriter(fs);
            // sw.WriteLine("welcome");
            // for
            //     (int i=0;i<2;i++)
            //{
            //    string s= Console.ReadLine();
            //    sw.WriteLine(s);
            // }
            // sw.Close();
            // fs.Close();

            // FileStream fs1 = new FileStream(@"E:\Navya\mydir\a.txt", FileMode.OpenOrCreate, FileAccess.Read);//read data from file
            // StreamReader sr = new StreamReader(fs1);
            //string s;
            //while((s=sr.ReadLine())!=null)
            //{
            //    Console.WriteLine(s);
            // }
            // sr.Close();
            // fs1.Close();

            //FileStream fs = new FileStream(@"E:\Navya\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Write);//writing binnary data into file
            //BinaryWriter bw = new BinaryWriter(fs);
            //int i = 10;
            //char ch = 'd';
            //string f = "hello";
            //bw.Write(i);
            //bw.Write(ch);
            //bw.Write(f);
            //bw.Close();
            //fs.Close();

            FileStream fs1 = new FileStream(@"E:\Navya\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int xe= br.ReadInt32();
            char y = br.ReadChar();
            string z = br.ReadString();
            Console.WriteLine(xe + " " + y + " " + z);
            br.Close();
            fs1.Close();


                       Console.ReadKey();
        }
    }
}
