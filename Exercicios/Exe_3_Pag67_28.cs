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
			
			int peso, altura, media, pessoas, quantidade = 0, qtd = 0, total = 0;
			double porcentagem;
			string nome;
			char sexo = ' ';
			
            Console.WriteLine("Lucas Ribeiro da Silva");

			Console.WriteLine("Digite o numero de pessoas");
			pessoas = int.Parse(Console.ReadLine());
			qtd = pessoas;
			
			do {
			    Console.WriteLine("Digite o seu nome");
			    nome = Console.ReadLine();
			 
			    // Verifica a variável sexo
			    while(!(sexo == 'F' || sexo == 'M')) {
			      	Console.WriteLine("Digite o seu sexo (M ou F)");
			        sexo = char.Parse(Console.ReadLine());
			    }
			    
			    Console.WriteLine("Digite a sua altura em cm");
			    altura = int.Parse(Console.ReadLine());

			    Console.WriteLine("Digite o seu peso em kg");
			    peso = int.Parse(Console.ReadLine());
			    
			    if (peso > 70 && peso < 80) {
	                quantidade++;
			    }
			    
			    if (sexo == 'M') {
			        total+= altura;
			    }

			    pessoas--;
			    sexo = ' ';
			} while(pessoas >= 1);
			
			media = total/qtd;
			porcentagem = quantidade*100/qtd;
			
			Console.WriteLine("Pessoas no grupo: " + qtd);
			Console.WriteLine("Pessoas com peso entre 70 e 80kg: " + quantidade + " representando " + porcentagem.ToString("0.00") + "%");
			Console.WriteLine("Media de altura entre os homens: " + media);

		}
	}
}
