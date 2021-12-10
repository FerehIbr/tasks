using System;

namespace taskarr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrtask1
            //int[] num = { 7, 9, 5, 3, 8, 2, 1, 99, 93, 91 };

            //for (int i = num.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(num[i]);
            //}
            #endregion
            #region minmaxarr
            //int[] arr = { 3, 333, 555, 222, 1111 };
            //int min =arr [0];
            //int max =arr [0];
            //for (int i = 0; i <arr.Length; i++)
            //{
            //    if (arr [i]>max)
            //    {
            //        max = arr[i];
            //    }
            //    else if (min>arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(min);
            //Console.WriteLine(max);

            #endregion

            #region 2eyni uzunluglu arr
            //int[] arr1 = { 1, 5, 9,7,3 };
            //int[] arr2 = { 8, 12, 10, 14,16 };
            //int[] arr3 =new int[arr1.Length + arr2.Length];
            //for (int i = 0, f=0; i <arr3.Length; i++)
            //{
            //    if (i<arr1.Length)
            //    {
            //        arr3[i] = arr1[i];
            //    }
            //    if (i== arr1.Length || i>arr1.Length)
            //    {
            //        arr3[i] = arr2[f];
            //        f++;
            //    }

            //}
            //foreach (var item in arr3)
            //{
            //    //Console.WriteLine(item);
            //}
            //Array.Sort(arr3);
            //Array.Reverse(arr3);
            //foreach (var item in arr3)
            //{

            //}
            //Console.WriteLine(string.Join(" ", arr3));

            #endregion

            #region 3reqemliededlerincemi
            int[] arr = { 333, 555, 88, 23, 99 };
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i]/100 >0 && arr[i]/1000==0)
                {
                    sum1 = arr[i];
                }
                if (arr[i] / 10 > 0 && arr[i] / 100 == 0)
                {
                    sum2 = arr[i];
                }
            }
            Console.WriteLine(sum1-sum2);
            #endregion
        }
    }
}
