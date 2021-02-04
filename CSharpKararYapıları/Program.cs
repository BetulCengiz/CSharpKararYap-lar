using System;

namespace CSharpKararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            //>> If-Else


            //string isim = "Nur";


            //if (isim == "Onur")
            //{
            //    Console.WriteLine("Doğru isim girişi");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış isim girişi");
            //}


            //int sayi;
            //Console.WriteLine("Lütfen sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi>0)
            //{
            //    Console.WriteLine("Pozitif sayı girdiniz");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı pozitif ya da negatif değil");
            //}
            //else
            //{
            //    Console.WriteLine("Negatif sayı girdiniz");
            //}


            //Klavyeden girilen sayının tek mi çift mi olduğunu bulmak. >> % mod alma işlemi için kullanılır.


            //int sayi;
            //Console.WriteLine("Bir sayı giriniz : ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tek");
            //}


            //Klavyeden girilen mevsime göre o mevsimin aylarını yazdırma


            string mevsim;
            Console.WriteLine("Bir mevsim giriniz");
            mevsim = Console.ReadLine();

            if (mevsim == "yaz")
            {
                Console.WriteLine("Yaz mevsiminin ayları: Haziran,Temmuz,Ağustos");
            }
            else if (mevsim == "kış")
            {
                Console.WriteLine("Kış mevsiminin ayları: Aralık,Ocak,Şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("İlkbahar mevsiminin ayları: Mart,Nisan,Mayıs");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Sonbahar mevsiminin ayları: Eylül,Ekim,Kasım");
            }
            else
            {
                Console.WriteLine("Girdiğiniz bir mevsim değil");
            }





        }
    }
}
