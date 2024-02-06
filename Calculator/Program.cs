using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, answer;
            string needed;
            Console.WriteLine("Hesap makinesine hoşgeldiniz! ENTER'a basın");
            Console.WriteLine("birinci numara giriniz:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci numara giriniz:");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi işlemi yapmak istiyorsanız yazın? toplama,çıkartma,çarpma,bölüm");
            needed= Convert.ToString(Console.ReadLine());
            if (needed == "toplama") { Console.WriteLine("result is "+(num1 + num2)); }
            if (needed=="çıkartma") { Console.WriteLine("result is "+ (num1 - num2)); }
            if (needed == "çarpma") { Console.WriteLine("result is "+(num1 * num2)); }
            if (needed == "bölüm") { Console.WriteLine("result is "+(num1 / num2)); }


            Console.ReadKey();

        }
    }
}
