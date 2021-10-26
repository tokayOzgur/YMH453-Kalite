using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4
{
    class Program
    {
        #region Uyg1 - Quick Sort
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
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

        static void Main(string[] args)
        {
            #region Uyg1 - Quick Sort
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // Sonuç

            //  1-2-4-11-5-12-6-13-15-8-16-10 ---- 3
            //  1-2-3 
            //  1-2-4-5-12-6-13-15-8-16-10 ---- 3
            //  1-2-4-11-5-6-13-14-8-16-10 ---- 3
            //  1-2-4-5-6-7-8-9-18-10 --------- 3
            //  1-2-4-5-6-7-8-9-18-17 --------- 3
            // vb
            #endregion

            Console.WriteLine("\n******************************************************************************");

            #region Uyg2 - Binary
            // Girilen sayıyı ikili kod (binary) haline çeviren prgoramı yazın

            int value = 8;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("\n \n Binary değeri= " + binary);

            //Sonuç
            // 1-2-3-4
            #endregion

            Console.WriteLine("\n******************************************************************************");

            #region Uyg3 - 

            void maxsum(int maxint, int val)
            {
                int result = 0;
                int i = 0;
                if (val < 0)
                {
                    val = -val;
                }
                while (i < val && result <= maxint)
                {
                    i = i + 1;
                    result = result + i;
                }
                if (result <= maxint)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("too large");
                }
            }
            maxsum(10, 5);

            // Sonuç

            // 1-2-3-7-4-5-6
            // 1-2-3-7-4-8-6
            // 1-2-3-4-5-6
            // 1-2-3-4-8-6
            #endregion

            Console.WriteLine("\n******************************************************************************");

            #region Uyg4 - 
            int count = 0;
            Console.WriteLine("a değerini giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b değerini giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                while (b > 0)
                {
                    b--;
                    count++;
                }
            }
            else if (a > 0)
            {
                while (b < 0)
                {
                    b++;
                    count--;
                }
            }
            else
            {
                a = b;
            }
            Console.WriteLine("\n" + a + "\n" + b + "\n" + count);

            // Sonuç

            // 1-2-3-4-5-6
            // 1-2-3-7-8-9-10-4-11-12
            // 1-2-3-7-8-9-10-4-11-13-14-12
            // 1-2-3-7-8-9-10-4-5-6

            #endregion

            Console.WriteLine("\n******************************************************************************");

            Console.ReadLine();
        }
    }
}
