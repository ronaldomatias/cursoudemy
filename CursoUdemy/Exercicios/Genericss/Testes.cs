using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Genericss
{
    internal class Testes
    {

        public void teste()
        {
            try
            {
                MostrarValores<int> mv = new MostrarValores<int>();
                mv.AddValor(2);
                mv.AddValor(3);
                mv.AddValor(4);
                mv.AddValor(5);
                mv.AddValor(6);
                mv.AddValor(7);
                mv.AddValor(1);
                mv.AddValor(9);
                mv.AddValor(0);
                mv.AddValor(44);
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
    }
}
