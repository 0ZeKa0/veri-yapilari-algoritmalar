using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class src
    {
        public int[] dizi= new int[10];
        public int target;
     
        public src(int[] sayilar,int target)
        {
            this.target = target;
            this.dizi = sayilar;
            Search(dizi, target);
        }

        public void Search(int[] dizi,int target)
        {
            Console.WriteLine(PrivateSearch(dizi,target));
        }
        private int PrivateSearch(int[] dizi, int target) {

            int left = 0;
            int right = dizi.Length - 1;
            while (left <= right)
            {
                int mid= (left+right)/2;    
                if (dizi[mid]==target)
                {
                    return mid;
                }
                else if (target <= dizi[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
