using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace fibonacci_eleman_sayilari
{
    class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            int x = 0;
            int y = 1;
            int n;

            Console.Write("Kac Tane Fibonocci Sayisi Gormek Istiyorsunuz? = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(x + ", " + y + ", ");

            for (int s = 3; s <= n; s++)
            {//for başlangıç

                int z = x + y;
                Console.Write(z + ", ");
                x = y;
                y = z;

               if (y>=1000)
            {
                Console.WriteLine("  "); 
                Console.Write("18. eleman 1597 değerinde 1000'i gectigi icin Tekrar Dene!!!\n ");
                goto tekrar;
            }

             }//for Bitiş


            Console.WriteLine(" ");
            Console.Write(n + " Tane eleman gözükmektedir ");


            Console.ReadLine();
        }
    }
}