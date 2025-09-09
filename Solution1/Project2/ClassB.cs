using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2
{
    internal class Three
    {
        //call one,two,main
        public void Meth3()
        {
            // 1 internal 

            /*
             
             * internal = Not accessible in different namespace due to restriction 
            
            One obj1= new One();
            obj1.Meth1();
            
             */


            // 2 public
            Two obj2= new Two();
            obj2.Meth2();


            // 3 main
            AccessClassInDifferentNamespace.Main();
        }
    }
    public class Four 
    {
        //call one,two,main
        public void Meth4()
        {
            // 1 internal
            /*

                 // internal = Not accessible in different namespace due to restriction 

                One obj1= new One();
                obj1.Meth1();

             */
            
            // 2 public
            Two obj2 = new Two();
            obj2.Meth2();

            // 3 main
            AccessClassInDifferentNamespace.Main();

        }
    }
    internal class ClassB
    {
        static void Main(string[] args)
        {

            Three obj2 = new Three();
            obj2.Meth3();
            Four four = new Four();
            four.Meth4();
        }
    }
}
