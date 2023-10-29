// See https://aka.ms/new-console-template for more information


namespace Algoritms
{
    public struct Ogretmen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas {  get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "zera";
            ogretmen.Soyad = "kara";
            ogretmen.Yas = 100;

            Console.WriteLine($"{ogretmen.Ad}"+" "+$"{ogretmen.Soyad}");
        }
    }



}
