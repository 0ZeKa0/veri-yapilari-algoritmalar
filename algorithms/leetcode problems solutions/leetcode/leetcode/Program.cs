using DocumentFormat.OpenXml.ExtendedProperties;
using leetcode;
using NHibernate.Mapping;
using System;
using System.Collections;
using System.Collections.Generic;

class GFG
{

    // Main Method
    static public void Main()
    {
        int[]arr= { 2,7,8,1};
        int target = 9;
        string s = "abbcbdba";
        Console.WriteLine(sum(arr,target));
        int vl1 = 2, vl2 = 4, vl3 = 3, vl4 = 5, vl5 = 6, vl6 = 4;
        int[] arr1 = { vl1, vl2, vl3 };
        int[] arr2 = { vl4, vl5, vl6 };

        LinkedList l1 = new LinkedList();
        LinkedList l2 = new LinkedList();

        l1.addToEnd(vl1);
        l1.addToEnd(vl2);
        l1.addToEnd(vl3);
        l2.addToEnd(vl4);
        l2.addToEnd(vl5);
        l2.addToEnd(vl6);

        Linked_List_Sum(arr1, arr2);
        lengthOfLongestSubsitring(s);
         
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
    static void Linked_List_Sum(int[]arr1, int[]arr2)
    {
        LinkedList l3 = new LinkedList();
        int carry = 0;
        
        int i = 0;

        while( i<3)
        {
            int l1_val=0, l2_val=0;

            if (arr1[i]!=null)
            {
                l1_val = arr1[i];
            }
            else
            {
                l1_val = 0;
            }
            if (arr2[i]!=null)
            {
                l2_val = arr2[i];
            }
            else
            {
                l2_val = 0;
            }

            int result = l1_val + l2_val + carry;
            carry = result / 10;
            int last_digit = result % 10;
            l3.addToEnd(last_digit);

            i++;
        }
        if (carry > 0)
        {
            l3.addToEnd(carry);
        }
        l3.print();
    }

    public SingleNode LinkedListSum(SingleNode l1,SingleNode l2)
    {
        SingleNode head = new SingleNode(0);
        SingleNode l3 = head;
        int carry = 0;

        int l1_val = 0;
        int l2_val = 0;
        int totalsize = 0;

        while (l1!=null || l2 !=null)
        {
            l1_val = (l1 != null) ? l1.data : 0;
            l2_val = (l2 != null) ? l2.data : 0;

            totalsize = l1_val+l2_val + carry;
            carry=totalsize / 10;
            int last_digit = totalsize % 10;

            SingleNode node = new SingleNode(last_digit);
            l3 = l3.next;

            if (l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        if (carry > 0)
        {
            l3.next= new SingleNode(carry);
        }

        return head.next;
    }

    public static int lengthOfLongestSubsitring(String s)
    {
        int start = 0, len = 0;
        var map = new Hashtable();

        for (int end=0; end<s.Length;end++)
        {
            char c = s[end];
            if (map.ContainsKey(c))
            {
                if (start<=map))
                {

                }
            }
        }

        return len;
    }

}
