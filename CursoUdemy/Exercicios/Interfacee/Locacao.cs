using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee
{
    internal class Locacao
    {
        public double ValorDiario { get; set; }
        public double ValorPorHora { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime InicioLocacao { get; set; }
        public DateTime FimLocacao { get; set; }

        public Locacao(double valorDiario, double valorPorHora, Veiculo veiculo, DateTime inicioLocacao, DateTime fimLocacao)
        {
            ValorDiario = valorDiario;
            ValorPorHora = valorPorHora;
            Veiculo = veiculo;
            InicioLocacao = inicioLocacao;
            FimLocacao = fimLocacao;
        }
    
        public double DiasLocados()
        {
            TimeSpan tempoLocacao = FimLocacao.Subtract(InicioLocacao);

            return tempoLocacao.TotalDays;
        }
        public double HorasLocadas()
        {
            TimeSpan tempoLocacao = FimLocacao.Subtract(InicioLocacao);

            return tempoLocacao.TotalDays * 24;
        }
    
    
    
    }
}
