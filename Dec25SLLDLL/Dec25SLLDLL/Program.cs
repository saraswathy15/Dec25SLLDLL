using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25SLLDLL
{
    internal class Program
    {
        static void Fun1()
        {// void method means no return keyword never returns a values

        }
        public string Display()
        {
            //but last statememnt to be return along with same type
            return "hello";
        }
        public Program()//no parameter constructor
        {
        }
        static void Main(string[] args)
        {
            Fun1();//static member requires no instnce of class
            Program p = new Program();// will call line 18 
            string s = p.Display();//non static display() need instance of class
        }
    }
}
