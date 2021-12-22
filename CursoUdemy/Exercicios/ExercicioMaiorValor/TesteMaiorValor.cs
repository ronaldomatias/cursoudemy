using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Classes.ExercicioMaiorValor
{
    public class TesteMaiorValor
    {
        int maximo;

        public void maiorValor()
        {
            MaiorValor maiorValor = new MaiorValor();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor: ");
                int n = int.Parse(Console.ReadLine());

                maximo = maiorValor.MaiorValorr(n);
            }

            Console.WriteLine($"O maior valor foi {maximo}");
            Console.Read();
        }
    
    
    }
}
