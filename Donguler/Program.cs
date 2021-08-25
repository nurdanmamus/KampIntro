using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"java" , ".net"};  

            for (int i = 0; i < kurslar.Length; i++)   
            {
                Console.WriteLine(kurslar[i]);   
            }

            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs); 
            }

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = ".Net";
            kurs1.egitmen = "egitmen";
            kurs1.izlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "egitmen1";
            kurs2.izlemeOrani = 64;

            Kurs[] kurslar1 = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs kurs in kurslar1)
            {
                Console.WriteLine(kurs.kursAdi); 
            }

            //ternary operatörü şarta bağlı değer döndüren bir operatördür.
            //bir değişkene, methoda, property'e bir değer atarken, eğer bu değer
            //şarta bağlı olarak fark edecekse satır bazlı/tek satırda bu şart kontrolünü 
            //yaparak duruma göre değer döndürmemizi sağlayan bir kalıpsal operatördür.
            //kural : dönecek değerler aynı olmalıdır.

            bool medeniHal = true;
            string mesaj = medeniHal == true ?"evlilere kampanya" :"bekarlara kampanya"; 
            Console.WriteLine(mesaj);

            int x = 10;
            switch (x)
            {
                case 3:
                    break;
                case 5: 
                    Console.WriteLine("hello");
                    break;
                default: goto case 5; 
                    Console.WriteLine(".net core");
                    break; 
            }

            int sayi = int.Parse(Console.ReadLine());

            while (sayi>=0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }

            int sayi2 = 1;
            int toplam = 0; 

            while (sayi2 <= 100)
            {
                toplam += sayi2;
                sayi2 += 2;
            }

            Console.WriteLine(toplam);

            int sayi3 = int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            while (sayi3 > 0)
            {
                faktoriyel *= sayi3--; 
            }

            Console.WriteLine(faktoriyel);

            while (true)
            {
                if (DateTime.Now.Second % 5 == 0) 
                {
                    Console.WriteLine(DateTime.Now);
                    break; 
                }
            }

            Console.Read(); 
        }
    }

    class Kurs 
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; } 
        public int izlemeOrani { get; set; }
    }
}
