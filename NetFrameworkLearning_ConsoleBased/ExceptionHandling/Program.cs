using ExceptionHandling.OutOfBound;
using ExceptionHandling.UserDefineException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayClass obj1 = new ArrayClass();
            obj1.ArrayDemo();

            //age example
            try
            {
                validateAge(10);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        static void validateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("sorry age >18 only");
            }
        }
    }
}
