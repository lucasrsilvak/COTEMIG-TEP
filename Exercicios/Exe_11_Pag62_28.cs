using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0, i = 0;
            string str = "";
            
            Console.WriteLine("Lucas Ribeiro da Silva");
            
            Console.WriteLine("Digite um numero inteiro positivo");
            n = int.Parse(Console.ReadLine());

            for (i = n; i > 0; i--) {
                if (n%i == 0) {
                    str = str + ", " + i;
                }
            }
            
            Console.WriteLine("Divisores do numero " + n + ":" + str.Substring(1,(str.Length - 1)));
            
        }
    }
}
