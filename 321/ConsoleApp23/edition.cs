using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
   public  abstract class Edition : IComparable
    {
        public string Name;
        public string Author;
        

        public abstract void Show(StreamWriter g);
        public abstract bool IsEdition(string temp);
        public int CompareTo(object obj)
        {
            Edition b = (Edition)obj;
            if (this.Author == b.Author)
            {
                return 0;
            }
            else
            {
                if (this.Author.CompareTo(b.Author) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
