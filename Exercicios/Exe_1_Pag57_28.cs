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
			
			char sexo = ' ', freq = ' ';
			int total = 0, total_f = 0, total_m = 0;
			
			Console.WriteLine("Lucas Ribeiro da Silva");
		    Console.WriteLine("Digite o total de alunos");
            total = int.Parse(Console.ReadLine());
            
			for (int i = 0; i < total ; i++)
			{
			    sexo = ' ';
			    freq = ' ';
    			while (!(sexo == 'F' || sexo == 'M') && !(freq == '0' || freq == '1'))
    			{
    			    Console.WriteLine("Digite o sexo do aluno (F = Feminino, M = Masculino)");
                    sexo = char.Parse(Console.ReadLine());
                    
    			    Console.WriteLine("Digite a frequencia do aluno (0 - Presente, 1 - Ausente)");
    			    freq = char.Parse(Console.ReadLine());
    			}
    			switch (freq) {
    			    case '1':
                        switch(sexo) {
                            case 'F':
                                total_f++;
                                break;
                            case 'M':
                                total_m++;
                                break;
                        }
                        break;
    			}
            }
            
            Console.WriteLine("Total de alunos ausentes do sexo masculino: " + total_m);
            Console.WriteLine("Total de alunos ausentes do sexo feminino: " + total_f);

            Console.ReadKey();
		}
	}
}
