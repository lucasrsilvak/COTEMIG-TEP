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
			
			int total = 0, num = 0, num_t = 0;
			double media = 0;
			
			Console.WriteLine("Lucas Ribeiro da Silva");
            Console.WriteLine("Digite quantos numeros vai inserir");
            total = int.Parse(Console.ReadLine());
            
			for (int i = 0; i < total ; i++)
			{
            	Console.WriteLine("Digite um numero");
            	num_t += int.Parse(Console.ReadLine());
			}
			
			media = num_t / total;

            Console.WriteLine("Media: " + media.ToString("F"));
            Console.ReadKey();
		}
	}
}
