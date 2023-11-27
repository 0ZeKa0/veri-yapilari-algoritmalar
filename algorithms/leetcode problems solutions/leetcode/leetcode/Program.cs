using leetcode;
using System;
using System.Collections.Generic;

class GFG
{

    // Main Method
    static public void Main()
    {
        int[]arr= { 2,7,8,1};
        int target = 9;
        Console.WriteLine(sum(arr,target));
    }
    // istenilen toplam için dizi içinden sayılar bulup toplama işlemi
    // bu fonksiyon yalnızca 1 çift gönderir. 
    // O(n^2) dir. 

    static string  sum(int[] arr,int target)
    {
        int result = 0;
        int[,] indices = new int[1, 2];
        for(int i = 0;i<arr.Length;i++)
        {
            indices[0, 0] = i; //ilk indise arrdaydeki değer atandı. Ama değer değil indis isteniyor.
                               //Bu sebeple direkt indis atamasıyaptım.
            result = target - arr[i];
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == result)
                {
                    indices[0, 1] = j;
                    return indices[0, 0]+ " " + indices[0,1];
                }

            }
        }
        return " ";
    }

    static int Linked_List_Sum(SingleNode l1, SingleNode l2)
    {

        while(l1!=null || l2!= null)
        {

        }
        return 0;
    }
}
