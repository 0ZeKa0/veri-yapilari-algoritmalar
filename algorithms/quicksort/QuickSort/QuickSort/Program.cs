using System;

namespace HelloWorldApp
{

    class QuickSort
    {

        static void Main(string[] args)
        {
            int[] array = { 3, 4, 5, 1, 8, 90 };

            QuickSortt(array,0,array.Length-1);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        private static void QuickSortt(int[] arr, int start, int end)
        {
            if (end <= start)
                return;
            int pivot=Partition(arr,start,end);
            QuickSortt(arr,start,pivot-1);
            QuickSortt(arr,pivot+1,end);
        } 
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;
            for (int j=start; j<=end-1;j++)
            {
                if (arr[j]<pivot)
                {
                    i++;
                    Swap(arr,i,j);
                }
            }
            i++;
            Swap(arr,i,end);

            return i;
        }
        private static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

    }

}
