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
		    int totalIdade = 0, idade = 0, cont = 0;
		    string totalName = "",name = "";
		    
		    for (cont = 1; cont <= 10; cont++)
		    {
		        Console.WriteLine("Digite seu nome: ");
		        name = Console.ReadLine();
		        
		        Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                
                totalIdade = totalIdade + idade;
                if (idade > 21) {
                    totalName = (totalName + " " + name);
                }
		    }
            Console.WriteLine("Nome das pessoas com mais de 21 anos:");
            Console.WriteLine(totalName);
            Console.WriteLine("Soma das idades:");
            Console.WriteLine(totalIdade);
		}
	}
}
