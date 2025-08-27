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
		    int cont = 0, total = 0, number = 0;
		    bool saida = true;

            Console.WriteLine("Digite seu numero: ");
	        number = int.Parse(Console.ReadLine());
            
            total = number;
            
            if (number > 0) {
	            for (cont = number; cont >= 1; cont--)
		        {
                    total = total * cont;
		        }
            } else {
                saida = false;
            }
                
		    total = total/number;
		    
		    if (saida) {
		        Console.WriteLine("Fatorial do numero " + number + " = " + total);
		    } else {
		        Console.WriteLine("E necessario inserir um numero positivo!");
		    }
		    
		}
	}
}
