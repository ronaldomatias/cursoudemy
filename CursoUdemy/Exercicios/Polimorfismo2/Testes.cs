using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo2
{
    internal class Testes
    {
        public void teste()
        {
            List<Produto> listaProdutos = new List<Produto>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Produto importado, usado ou comum? (i/u/c");
                char c = char.Parse(Console.ReadLine());

                Console.WriteLine("Nome?");
                string nome = Console.ReadLine();

                Console.WriteLine("Preço?");
                double preco = double.Parse(Console.ReadLine());

                if (c == 'i')
                {
                    Console.WriteLine("Taxa importação?");
                    double taxaAlfandega = double.Parse(Console.ReadLine());
                    listaProdutos.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
                else if (c == 'u')
                {
                    Console.WriteLine("Data fabricação?");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    listaProdutos.Add(new ProdutoUsado(nome, preco, data));
                }
                else if (c == 'c')
                {
                    listaProdutos.Add(new Produto(nome, preco));
                }
            }

            foreach(Produto p in listaProdutos) {
                Console.WriteLine(p.EtiquetaPreco());
            }
            


        }

    }
}
