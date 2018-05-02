using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    public class Article: Edition
    {
        string type = "Article";
        int Number;
        string Journal;
        int Year;
        public Article(string Name, string Author, string Journal, int Number, int Year)
        {
            this.Name = Name;
            this.Author = Author;
            this.Journal = Journal;
            this.Number = Number;
            this.Year = Year;
        }

        public override void Show(StreamWriter g)
        {
            g.WriteLine("Name : {0}, Author : {1}, Journal : {2}, Number : {3}, Year : {4} ", Name, Author, Journal, Number, Year);
        }
        public override bool IsEdition(string temp)
        {
            return temp.Contains(type);
        }
    }
}
