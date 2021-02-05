using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama (DRY)
            //değer tutucu, alias
            
            //Aslında aşağıda tip belirlerken string, int vs yerine 'var' kullanabiliriz. Sonrasında değere göre C# değişken tipini kendisi tanıyabilir.
            //Fakat yukarıda bahsettiğimiz tip güvenli bir kullanım senaryosu olduğundan 'var' kullanımını tercih etmeyiz.            
            //string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi = 37000;
            //double faizOrani = 1.42;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme giriş yapıldı.");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapınız");
            }

            double dolarDun = 7.42;
            double dolarBugun = 7.42;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.Write("Çizgi");
            }

            Console.ReadKey();
        }
    }
}
