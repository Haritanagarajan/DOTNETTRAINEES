//directives
//#define Bubblesort
#define Quicksort

//namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Directives
    {

#if Bubblesort

//#warning bubbleosrt array  is required
//#error bubblesort  array  is required


        #region bubblesort
        public void bubblesort()
        {
            int[] n = { 100, 23, 1, 25, 76, 90, 56, 23 };

            int len = n.Length;

            //swapping if greater than comparable value
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len - i - 1; j++)
                    if (n[j] > n[j + 1])
                    {
                        //swap
                        var temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;
                    }

            foreach (int i in n)
            {
                Console.WriteLine(i);

            }

        }
        #endregion

#elif Quicksort

//#pragma warning disable
//#warning quicksort  array  is required
//#error quicksort  array  is required
//#pragma warning restore
//#warning quicksort array need some values

        #region quicksort
        public void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quicksort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quicksort(arr, pivot + 1, right);
                }
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }

        }
        #endregion

#endif


    }


    internal class MainDirectives
    {
        static void Main(string[] args)
        {
            //line
#line 116 "Directives.cs"
            //Directivess directives = new Directives();

            Directives directives = new Directives();


#if Bubblesort
            #region bubblesort
            directives.bubblesort();
#endregion

#elif Quicksort
            //quicksort
           #region quicksort
            int[] arr = new int[] { 1, 20, 50, 80, 2, 5, 8 };
            Console.WriteLine("Original array : ");
            foreach (var sortedlist in arr)
            {
                Console.Write(" " + sortedlist);
            }
            Console.WriteLine();
            directives.Quicksort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
            foreach (var sortedlist in arr)
            {
                Console.Write(" " + sortedlist);
            }
            Console.WriteLine();
            Console.ReadLine();
            #endregion
#endif


        }
    }

}



