using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class1
    {
        public void meth1()
        {
            Console.WriteLine("Class1 called");
            //2. calling class2 from class1
            Class2 obj1 = new Class2();
            obj1.meth2();
        }
       

    }
    internal class Class2
    {
        public void meth2()
        {
            Console.WriteLine("Class2 called");
            Class3.methStatic();
        }
    }
    internal class Class3
    {
        //3. access from a static method
        public static void methStatic()
        {
            Console.WriteLine("Class3 with static method called");
            //4. access a normal class method from a static method
            Class4 obj1 = new Class4();
            obj1.meth4();

        }
    }

    internal class Class4
    {
        
        public void meth4()
        {
            Console.WriteLine("Class4 called from static method");

        }
    }
    internal class AccessClassInSameNamespace
    {

        
        static void Main(string[] args)
        {
            //1. class called from main
            Class1 obj1= new Class1();
            obj1.meth1();
            
        }
    }
}
