using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning.waysToCreateArray
{
    internal class Way1
    {
        /*with fixed size*/


        int [] arr1 = new int[2];
       
        //bad declaration type:  int arr2[] = new int[2];

        public void Show()
        {
            Console.WriteLine("Way 1 to create array");
            Console.WriteLine(arr1[0] = 1);
            Console.WriteLine("The element at arr[0]={0}  and arr[1]={1}", arr1[0], arr1[1]);
        }
    }
}
