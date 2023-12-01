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

        LinkedList l1 = new LinkedList();
        LinkedList l2 = new LinkedList();

        l1.addToEnd(2);
        l1.addToEnd(4);
        l1.addToEnd(3);
        l2.addToEnd(5);
        l2.addToEnd(6);
        l2.addToEnd(4);

        Linked_List_Sum(l1, l2);

        
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
    // Dolu iki listenin her bir nodu bir sayının basamağını ifade ediyor.
    // Örneğin 342 sayısı 2 -> 4 -> 3 şeklinde listeye ekleniyor.
    // İki liste elemanının sahip olduğu sayıların toplamı ise l3 adındaki üçüncü bir listeye
    // eklenmiş olacak.
    // Probleme linkedliste after işlemi ile ekleme yapmayı öğrendikten sonra devam edilecek.
    static void Linked_List_Sum(LinkedList l1, LinkedList l2)
    {
        LinkedList l3 = new LinkedList();
        int carry = 0;
        int result = 0;
        int i = 0;

        while(l1!=null || l2!= null)
        {
            int l1_val=0, l2_val=0, last_digit=0;

            if (l1!=null)
            {
                l1_val = l1.ReturnHead();
            }
            else
            {
                l1_val = 0;
            }
            if (l2!=null)
            {
                l2_val = l2.ReturnHead();
            }
            else
            {
                l2_val = 0;
            }

            result = l1_val + l2_val + carry;
            carry = result / 10;
            last_digit = result % 10;
            l3.addToEnd(last_digit);

            l3.print();

            i++;
        }
 
    }
}
