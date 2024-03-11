
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_deger_arasındaki_sayıların_toplamını_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1=0, sayi2, toplam = 0;
            

            Console.WriteLine("Lütfen 1. sayıyı giriniz:");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz;");
            sayi2= Convert.ToInt32(Console.ReadLine());
            int orjinalsayi = sayi1;
            int dongusayisi = sayi2 - sayi1 + 1;

            while(dongusayisi > 0)
            {
                toplam += sayi1;
                sayi1++;

                dongusayisi--;
            }

            Console.WriteLine("{0} - {1} arasındaki sayıların toplamı: {2}",orjinalsayi, sayi2,toplam);
            Console.ReadLine();

        }
    }
}
