using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal static class StaticClassStudy
    {

        //1. only allowed to write static members inside static class

        /*public void Meth1()
         * Not allowed
        {
            Console.WriteLine("non static method allow in static class");
        }*/


        //2. You have to write static keyword : there is no such things as everything inside static class will have a static scope by default

        /*
         void Meth2()
        {
            Console.WriteLine("everything inside static class is by default static");
        }*/


        //3. calling a static method
        internal static void Meth3()
        {
            Console.WriteLine("proper defined static method called");
        }

        static void  Main()
        {
            /*
             * Not allowed
            StaticClassStudy obj1 = new StaticClassStudy();
            obj1.Meth1();*/


            /*
             * Not allowed
            StaticClassStudy obj2 = new StaticClassStudy();
            obj1.Meth2();*/

            //4. cannot create obj of static class
            StaticClassStudy.Meth3();

            //5.1 calling a static method from different static class
            DifferentStaticClass.Meth4();

        }


    }

    //5. calling static class from different static class
    internal static class DifferentStaticClass
    {

        internal static void Meth4()
        {
            Console.WriteLine("a static class called method of other static class");

            //6.1 calling non static from static class
            NonStaticClass obj1 = new NonStaticClass();
                obj1.Meth5();
        }

    }
    //6. calling static class from different non static class
    internal class NonStaticClass
    {
        internal  void Meth5() {
            Console.WriteLine("a non static class method is called from a static class");
            //6.2 calling a static class from non static
            StaticClassStudy.Meth3();
        }

    }
}
