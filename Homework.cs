using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = "asdyyhiu213434598/'sdfi!ihgfd@ad";
            StringBuilder result = new StringBuilder();
            string rez = string.Empty;
            string symbols="!@#$%^&*()-+[]{}<>/'";
            foreach(char item in start)
            {
                foreach(char c in symbols)
                {
                    if(item == c)
                    {
                        result.Append(c);
                    }
                }               
            }
            Console.WriteLine(result);
        }
    }
}
