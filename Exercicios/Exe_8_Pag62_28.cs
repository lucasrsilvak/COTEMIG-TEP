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

            char sexo = ' ';
            int altura = 0, maior = int.MinValue, menor = int.MaxValue, media = 0, mediaF = 0, cont = 0;
            
            Console.WriteLine("Lucas Ribeiro da Silva");

            for(cont = 1; cont <= 10; cont++)
            
            {
                Console.WriteLine("Digite o seu sexo (1:Masculino, 2:Feminino)");
                sexo = char.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite sua altura (cm)");
                altura = int.Parse(Console.ReadLine());
                
                if (altura > maior) {
                    maior = altura;
                }
                
                if (altura < menor) {
                    menor = altura;
                }
                
                
                media += altura;
                
                switch (sexo) {
                    case '2':
                        mediaF += altura;
                        break;
                }
            }

            media = media/10;
            mediaF = mediaF/10;
            
            Console.WriteLine("Maior altura: " + maior);
            Console.WriteLine("Menor altura: " + menor);
            Console.WriteLine("Media mulheres: " + mediaF);
            Console.WriteLine("Media turma: " + media);
            
            Console.ReadKey();
            
        }
    }
}