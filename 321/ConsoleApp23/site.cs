using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    public class Site : Edition
    {
        string type = "Site";
        string Link;
        string Annotation;

        public Site(string Name, string Author, string Link, string Annotation)
        {
            this.Name = Name;
            this.Author = Author;
            this.Link = Link;
            this.Annotation = Annotation;
        }

        public override void Show(StreamWriter g)
        {
            g.WriteLine("Name : {0}, \nAuthor : {1}, \nLink : {2}, \nAnnotation  : {3}", Name, Author, Link, Annotation);
            g.WriteLine();
        }

        
        public override bool IsEdition(string temp)
        {
            return temp.Contains(type);
        }
    }
}
