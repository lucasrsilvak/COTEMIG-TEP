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
            
            double teto = 500, maior = double.MinValue, menor = double.MaxValue;
            int salario, cont = 0, porcentagem = 0;
            
            Console.WriteLine("Lucas Ribeiro da Silva");

            for(cont = 1; cont <= 10; cont++) {
            
                Console.WriteLine("Digite seu salario:");
                salario = int.Parse(Console.ReadLine());
                
                if (salario > maior) {
                    maior = salario;
                }
                
                if (salario < menor) {
                    menor = salario;
                }
                
                if (salario < teto) {
                    porcentagem++;
                }
            }
            
            porcentagem = porcentagem * 100 / 10;
            
            Console.WriteLine("Menor Salario: " + menor);
            Console.WriteLine("Maior Salario: " + maior);
            Console.WriteLine("Porcentagem de trabalhadores que ganham menos de 500: " + porcentagem + "%");
            
        }
    }
}
