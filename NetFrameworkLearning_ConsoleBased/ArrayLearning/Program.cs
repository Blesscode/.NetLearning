using ArrayLearning.waysToCreateArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Way1 obj = new Way1();
            obj.Show();

            // Console.ReadLine();
            Way2 obj2 = new Way2();
            obj2.Show();

            Way3 obj3 = new Way3();
            obj3.Show();
        }
    }
}
