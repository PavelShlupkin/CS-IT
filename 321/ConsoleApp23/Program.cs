using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
        StreamReader f = new StreamReader("input.txt", System.Text.Encoding.GetEncoding(1251));
        StreamWriter g = new StreamWriter("output.txt");
        string temp = f.ReadLine();
            Site[] site = new Site[7];
            for (int i = 0; i < site.Length; i++)
            {
                string[] x = f.ReadLine().Split(' ');
                string Name = x[0];
                string Author = x[1]; 
                string Link = x[2];
                string Annotation = x[3];
                site[i] = new Site(Name, Author, Link, Annotation);
            }
            
            
            Array.Sort(site);
            foreach(Edition a in site)
            {   
                a.Show(g);
            }
            f.Close();
            g.Close();
        }
    }
}
