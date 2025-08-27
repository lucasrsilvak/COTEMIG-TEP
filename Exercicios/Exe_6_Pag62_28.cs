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
		    int menor = 0, maior = 0, feminino = 0, masculino = 0, idade = 0, cont = 0, media = 0;
		    string name = "";
		    char sexo = 'N';

		    for (cont = 1; cont <= 10; cont++)
		    {
		        Console.WriteLine("Digite seu nome: ");
		        name = Console.ReadLine();
		        
		        Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite seu sexo F ou M: ");
                sexo = char.Parse(Console.ReadLine());
                
                if (idade >= 18) {
                    maior ++;
                } else {
                    menor ++;
                }
                switch (sexo)
                {
                    case 'F':
                        feminino ++;
                        break;
                    case 'M':
                        masculino ++;
                        break;
                }
                        
		    }
		    
		    media = maior*100/(maior+menor);
            Console.WriteLine("Homens: " + masculino);
            Console.WriteLine("Mulheres: " + feminino);
            Console.WriteLine("Menores: " + menor + " equivale a " + media + "%");
            Console.WriteLine("Maiores: " + maior + " equivale a " + (100 - media) + "%");
		}
	}
}
