using System;

namespace Params_Anahtar_Sozcugu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             params parametler demek bir fonksiyonda kullanılır
            fonksiyona çok fazla değer gönderilecekse kullanılır
             */
            Console.WriteLine(islem('+', 1, 2, 3));
            Console.WriteLine(islem('*', 2, 2, 3));


        }
        static int islem(char isx, params int[] sayilar)
        {
            int sonuc = 0;
            if (isx == '+')
            {
                Console.WriteLine("Toplama");
                foreach (var item in sayilar)
                {
                    sonuc += item;
                }
            }
            
            if (isx == '*')
            {
               sonuc = 1;
             Console.WriteLine("Çarp");
                foreach (var item in sayilar)
                {
                    sonuc = sonuc * item;
                }

            }
            return sonuc;
        }
    }
}
