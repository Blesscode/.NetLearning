using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class AccessOrderInAClass
    {
        static float pi = 3.14f;
        int evenNo = 2;

        static AccessOrderInAClass()
        {
            Console.WriteLine("init value of pi= " + pi);
            pi = 3.146f;
            Console.WriteLine($"static constructor value of pi= {pi}");
        }
        void meth1()
        {
            Console.WriteLine("start");
        }

        AccessOrderInAClass()
        {
            evenNo = 4;
            pi = 3.14568f;
            Console.WriteLine($"normal constructor value of pi= {pi} & even no={evenNo}");
        }
        static void meth2()
        {
            Console.WriteLine("end");
            {
                Console.WriteLine("Normal Block called");
            }
        }

        static void Main( string[] args)
        {
            new AccessOrderInAClass().meth1();
            AccessOrderInAClass.meth2();
        }

    }
}
