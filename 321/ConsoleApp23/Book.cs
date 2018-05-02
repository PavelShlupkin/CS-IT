using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    public class Book : Edition
    {
        string type = "Book";
        int Year;
        string Publishing_House;

        public Book(string Name,  string Author, int Year, string Publishing_House)
        {
            this.Name = Name;
            this.Author = Author;
            this.Year = Year;
            this.Publishing_House = Publishing_House;
           
        }

        public override void Show(StreamWriter g)
        {
            g.WriteLine("Name : {0},  Author : {1}, Year : {2},Publishing_House  : {3}", Name,  Author,Year, Publishing_House);
        }
        public override bool IsEdition(string temp)
        {
            return temp.Contains(type);
        }
    }
}
