// See https://aka.ms/new-console-template for more information


namespace Algoritms
{
    public struct Ogretmen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public Ogretmen(string ad, string soyad, int yas)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;

        }

        public override string ToString()
        {
            return Ad +" "+ Soyad +" "+ Yas;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "zera";
            ogretmen.Soyad = "kara";
            ogretmen.Yas = 100;

            var OgretmenListe = new List<Ogretmen>()
            {
                new Ogretmen("ad","soyad",20),
                new Ogretmen("ad","soyad",20),
                new Ogretmen("ad","soyad",20),
                new Ogretmen("ad","soyad",20),
                new Ogretmen("ad","soyad",20)
            };

            foreach(Ogretmen o in OgretmenListe)
            {
                Console.WriteLine(o);

            }
            OgretmenListe.ForEach(o => Console.WriteLine(o));
        }
    }



}
