using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee
{
    internal class Testes
    {

        public void teste()
        {
            Console.WriteLine("Valor por hora");
            double valorPorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por dia");
            double valorDiario = double.Parse(Console.ReadLine());

            Console.WriteLine("Modelo do carro:");
            string nomeVeiculo = Console.ReadLine();
            Veiculo veiculo = new Veiculo(nomeVeiculo);

            Console.WriteLine("Inicio da locação");
            DateTime inicioLocacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("fim da locação");
            DateTime fimLocacao = DateTime.Parse(Console.ReadLine());

            Locacao locacao = new Locacao(valorDiario, valorPorHora, veiculo, inicioLocacao, fimLocacao);
            Imposto imposto = new ImpostoDoBrasil();
            Fatura fatura = new Fatura(locacao, imposto);

            Console.WriteLine();
            Console.WriteLine("Horas locados:" + locacao.HorasLocadas());
            Console.WriteLine("Dias locados:" + locacao.DiasLocados());
            Console.WriteLine();
            Console.WriteLine("Fatura:");
            Console.WriteLine("Valor locação: " + fatura.ValorLocacao);
            Console.WriteLine("Imposto: " + imposto.TaxaImposto(fatura.ValorLocacao));
            Console.WriteLine("Valor total: " + fatura.TotalPagamento);




        }

    }
}
