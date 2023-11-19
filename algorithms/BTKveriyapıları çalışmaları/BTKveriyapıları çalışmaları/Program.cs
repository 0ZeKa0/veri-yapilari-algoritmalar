using System.Collections;

namespace veriler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[] { 1, 2, 3,8,4,67,45,34 };
            var numbers = Array.CreateInstance(typeof(int),3);
            var arr = new ArrayList(sayilar);
            numbers.SetValue(1,0);
            numbers.SetValue(2,1);
            numbers.SetValue(3,2);

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers.GetValue(i));
            }

            arr.Sort();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //system.collection sınıfında hashtable vardır. nongenerictir.
            //boxing-unboxig kullanılmalıdır. 
            //hashtaleda indisleme yoktur.
            //(key,value) şeklinde bir kullanıma sahiptir
            //key ve value değerleri farklı obje kümelenmeleridir.
            //Hashtabe için bir interface vardır.

            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6,"Ankara");
            sehirler.Add(25, "Erzurum");

            foreach (DictionaryEntry  i in sehirler)
            {
                Console.WriteLine($"{i.Key}" + i.Value);
            }

            //SortedList
            //System.Collections sınıfına aittir.
            //Non-generictir.
            //Key-value çifti kullanılır. ve anahtarlar benzersizdir.
            // key sıralama yapılır ve bu sıralama işleme ekleme anında ypılır
            //sortedlistin hashtabledan farkı budur.
            //Hem key(anahtar) hem de indislerle erişim sağlanabilir. 
            //IndexofKey ile indis değerine ulaşılabilir.
            //IndexofValue
            //GetKey

        }
    }
}