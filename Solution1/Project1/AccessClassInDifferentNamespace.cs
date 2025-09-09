using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class One
    {
        public void Meth1()
        {
            Console.WriteLine("internal class called");
        }
        
    }
    public class Two
    {
        public void Meth2()
        {
            Console.WriteLine("public class called");
        }

    }


    public class AccessClassInDifferentNamespace
    {
        public static void Main()
        {
            Console.WriteLine("Main containing class Called");
        }

    }
}
