using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning.waysToCreateArray
{
    internal class Way3
    {
        /*Declare and Initialize with Explicit Size*/


        int[] arr1 = new int[3]{ 500, 2000, 30000 };
        
        //error : int[] arr1 = new int[2] { 1, 2, 3 };



        public void Show()
        {
            Console.WriteLine("Way 2 to create array");
            Console.WriteLine(arr1[0] = 10);
            Console.WriteLine("The element at arr[0]={0}  and arr[1]={1}", arr1[0], arr1[1]);
            //error : Console.WriteLine("The element at arr[0]={0}  and arr[1]={1}", arr2[0], arr2[1]);
        }
    }
}
