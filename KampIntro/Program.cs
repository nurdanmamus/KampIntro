using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety    
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            string ad;
            Console.WriteLine("Lütfen adınızı giriniz");
            ad = Console.Read().ToString();
            Console.WriteLine(ad);

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu"); 
            }
            else
            {
                Console.WriteLine("Giriş yap butonu"); 
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu"); 
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            Console.ReadKey(); 




        }
    }
}
