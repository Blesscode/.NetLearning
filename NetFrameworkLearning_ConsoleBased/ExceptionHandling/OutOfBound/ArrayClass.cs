using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.OutOfBound
{
    internal class ArrayClass
    {
        int[] marks = { 10,20,30};

        internal void ArrayDemo()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks are : "+marks[i]);
            }

            //invalid index access
            /* 
             * ERROR CAME HERE NOW TO HANDEL THIS
              Console.WriteLine(marks[3])*/

            try
            {
                Console.WriteLine(marks[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception has occured, check it Isha", e.Message);
                Console.WriteLine(e.Source);
                // throw;
            }
            finally
            {
                Console.WriteLine("thanks for accessing the elements of array");
            }

        }
    }
}
