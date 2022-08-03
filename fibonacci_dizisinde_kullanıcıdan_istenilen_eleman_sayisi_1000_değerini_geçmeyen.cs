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
            
            if(n<=17)
            {//if başlangıç
            
                 Console.Write(x + ", " + y + ", ");
                 
            for (int s = 3; s <= n; s++)
            {//for başlangıç
            
                int z = x + y;
                Console.Write(z + ", ");
                x = y;
                y = z;
                
            }//for Bitiş
            
            
            Console.WriteLine(" ");
            Console.Write(n + " Tane eleman gözükmektedir ");
            
            }//if Bitiş
            
            else
            {//else başlangıç
                Console.WriteLine(n + " Tane eleman 1000 değerini geçmektedir. Lütfen Tekrar Deneyin. ");
                goto tekrar;
            }//else Bitiş
           
            Console.ReadLine();
        }
    }
}
