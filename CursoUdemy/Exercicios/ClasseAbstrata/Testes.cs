using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ClasseAbstrata
{
    internal class Testes
    {

        public void teste()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Pessoa física ou jurídica? (f/j)");
                char c = char.Parse(Console.ReadLine());

                Console.WriteLine("Nome?");
                string nome = Console.ReadLine();

                Console.WriteLine("Rendimento anual?");
                double renda = double.Parse(Console.ReadLine());

                if (c == 'f')
                {
                    Console.WriteLine("Despezas médicas?");
                    double despMedica = double.Parse(Console.ReadLine());
                    PessoaFisica pf = new PessoaFisica(nome, renda, despMedica);
                    listaPessoas.Add(pf);
                }
                else if (c == 'j')
                {
                    Console.WriteLine("Número de funcionários?");
                    int numFunc = int.Parse(Console.ReadLine());
                    PessoaJuridica pj = new PessoaJuridica(nome, renda, numFunc);
                    listaPessoas.Add(pj);
                }
            }

            double soma = 0;
            foreach(Pessoa p in listaPessoas)
            {
                Console.WriteLine(p.Nome +" "+ p.ImpostoRenda());
                soma += p.ImpostoRenda();
            }

            Console.WriteLine(soma);

        }
    }
}
