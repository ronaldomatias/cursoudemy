using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoUdemy.Exercicios.Genericss.Restricoes;
using CursoUdemy.Exercicios.Polimorfismo2;

namespace CursoUdemy.Exercicios.Genericss
{
    internal class Testes
    {

        public void teste()
        {
            try
            {
                MostrarValores<int> mv = new MostrarValores<int>();
                mv.AddValor(44);
                mv.AddValor(2);
                mv.AddValor(3);
                mv.AddValor(4);
                mv.AddValor(5);
                mv.AddValor(6);
                mv.AddValor(7);
                mv.AddValor(1);
                mv.AddValor(9);
                mv.AddValor(0);
                
                Console.WriteLine("O primeiro valor foi: " + mv.PrimeiroValor());
                mv.ImprimirLista();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("O vetor está vazio!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("O vetor está cheio!");
            }
        }
    
        public void testeRestricoes()
        {
            List<Produto> listaProdutos = new List<Produto>();
            for (int i=0; i< 3; i++)
            {
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Preço:");
                double preco = double.Parse(Console.ReadLine());

                listaProdutos.Add(new Produto(nome, preco));
            }

            GerarValorMaximo gvm = new GerarValorMaximo();

            Produto produtoMaisCaro = gvm.ObterMaiorValor(listaProdutos);

            Console.WriteLine(produtoMaisCaro.Nome +" "+ produtoMaisCaro.Preco);
        }
    
    }
}
