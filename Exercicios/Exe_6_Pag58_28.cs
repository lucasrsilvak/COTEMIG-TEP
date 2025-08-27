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
		    
		    int t_ma = 0, t_mb = 0, t_mc = 0, t_fa = 0, t_fb = 0, t_fc = 0, media_ma = 0, media_fa = 0, media_mb = 0, media_fb = 0, media_fc = 0, media_mc = 0, total = 0, t_pecas = 0, pecas = 0;
		    double t_salario = 0, salario = 0, m_salario = 0, s_minimo = 1049.00;
		    string cartao = "", m_cartao = "";
		    char classe = ' ', sexo = ' ', m_sexo = ' ';
		    
		    Console.WriteLine("Lucas Ribeiro da Silva")
		    Console.WriteLine("Digite o total de funcionarios");
		    total = int.Parse(Console.ReadLine());
		    
		    for (int i = 0; i < total; i++) {
		        
		        cartao = "";
		        sexo = ' ';
		        pecas = 0;
		        
		        while (!(sexo == 'F' || sexo == 'M') && !(pecas < 0))
		        {
                    Console.WriteLine("Digite o numero do cartao");
                    cartao = Console.ReadLine();
                    Console.WriteLine("Digite o seu sexo (Masculino = M, Feminino = F)");
                	sexo = char.Parse(Console.ReadLine());
                	Console.WriteLine("Digite o total de pecas");
                	pecas = int.Parse(Console.ReadLine());
		        }
		        
		        t_pecas += pecas;
		        
    		    if (pecas < 30) {
    		        // Menos de 30
    		        salario = s_minimo;
    		        switch(sexo)
    		        {
    		            case 'M':
                            media_ma += pecas;
                            t_ma++;
    		                break;
    		            case 'F':
                            media_fa += pecas;
                            t_fa++;
    		                break;
    		        }
    		    } else if (pecas >= 30 && pecas < 35) {
    		        // De 31 a 35
    		        salario = s_minimo + ((pecas - 30)*0.03)*s_minimo;
    		        switch(sexo)
    		        {
    		            case 'M':
                            media_mb += pecas;
                            t_mb++;
    		                break;
    		            case 'F':
                            media_fb += pecas;
                            t_fb++;
    		                break;
    		        }
    		    } else {
    		        // Mais de 35
    		        salario = s_minimo + ((pecas - 30)*0.05)*s_minimo;
    		        switch(sexo)
    		        {
    		            case 'M':
                            media_mc += pecas;
                            t_mc++;
    		                break;
    		            case 'F':
                            media_fc += pecas;
                            t_fc++;
    		                break;
    		        }
    		    }
    		    
    		    if (t_ma != 0) {media_ma /= t_ma; }
    		    if (t_mb != 0) {media_mb /= t_mb; }
    		    if (t_mc != 0) {media_mc /= t_mc; }
    		    if (t_fa != 0) {media_fa /= t_fa; }
    		    if (t_fb != 0) {media_fb /= t_fb; }
    		    if (t_fc != 0) {media_fc /= t_fc; }
    		    
    		    if (salario > m_salario) {
    		        m_salario = salario;
    		        m_sexo = sexo;
    		        m_cartao = cartao;
    		    }
    		    
    		    Console.WriteLine("Seu salario e de " + salario.ToString("F"));
    		    
    		    t_salario += salario;
		    }
		    
		    Console.WriteLine("Folha Mensal de Pagamento " + t_salario);
		    Console.WriteLine("Total de pecas fabricadas " + t_pecas);
		    Console.WriteLine("Media de pecas das Classes A,B,C por homens: " + media_ma + ", " + media_mb + ", " + media_mc);
		    Console.WriteLine("Media de pecas das Classes A,B,C por mulheres: " + media_fa + ", " + media_fb + ", " + media_fc);
		    Console.WriteLine("Sexo, cartao e salario do trabalhador que fez maior pecas " + m_sexo + ", " + m_cartao + ", " + m_salario);
		    
		    Console.ReadKey();

		}
	}
}
