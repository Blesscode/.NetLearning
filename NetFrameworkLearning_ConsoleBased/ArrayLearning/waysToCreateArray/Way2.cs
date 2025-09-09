using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning.waysToCreateArray
{
    internal class Way2
    {

        /*with fixed value*/


        int[] arr1 = { 1,2,3};
        int[] arr2 = { };

        //bad declaration type:  int arr2[] = new int[2];

        public void Show()
        {
            Console.WriteLine("Way 2 to create array");
            Console.WriteLine(arr1[0] = 1);
            Console.WriteLine("The element at arr[0]={0}  and arr[1]={1}", arr1[0], arr1[1]);
           //error : Console.WriteLine("The element at arr[0]={0}  and arr[1]={1}", arr2[0], arr2[1]);
        }
    }
}
