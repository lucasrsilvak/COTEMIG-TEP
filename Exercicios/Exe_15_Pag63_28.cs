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
			
			int value;
			int maxIdx = 0, minIdx = 0;
			double min = int.MaxValue, max = int.MinValue, salario, media, total = 0;

			Console.WriteLine("Lucas Ribeiro da Silva");
			
			Console.WriteLine("Digite o numero de empregados: ");
			value = int.Parse(Console.ReadLine());

            for (int cont = value; cont >= 1; cont--) {
                Console.WriteLine("Digite o seu salario: ");
                salario = double.Parse(Console.ReadLine());
                
                if (salario < min) {
                    min = salario;
                    minIdx = cont;
                                }
                
                if (salario > max) {
                    max = salario;
                    maxIdx = cont;
                }
                
                total+= salario;
            }
            
            media = total/value;
            
            Console.WriteLine("Maior salario pertence ao empregado de codigo " + maxIdx + " com o valor de " + max);
            Console.WriteLine("Menor salario pertence ao empregado de codigo " + minIdx + " com o valor de " + min);
            Console.WriteLine("Folha de pagamento: " + total.ToString("0.00"));
            Console.WriteLine("Media de salario: " + media.ToString("0.00"));
		}
	}
}
