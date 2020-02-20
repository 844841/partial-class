

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class c
    {
        public void my()
        {
            Console.WriteLine("partial class 1");
        }
    }
    partial class c
    {
        public void x()
        {
            int a = 0;
            Console.Write(a);
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            demo.c obj = new demo.c();
            c obj1 = new c();
            c obj2 = new c();

            obj1.my();
            obj.m();
            obj2.x();
            obj1.x();
        }
    }
}
namespace demo
{
    class c
    {
        public void m()
        {
            Console.WriteLine("hei");
        }
    }
}


