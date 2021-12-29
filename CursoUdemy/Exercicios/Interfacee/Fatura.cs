using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee
{
    internal class Fatura
    {
        public Locacao Locacao { get; set; }
        public Imposto Imposto { get; set; }
        public double TotalAPagar { get; set; }
        public double ValorLocacao { get; set; }
        public double ValorImposto { get { return Imposto.TaxaImposto(ValorLocacao);}}


        public Fatura(Locacao locacao, Imposto imposto)
        {
            Locacao = locacao;
            Imposto = imposto;

            CalcularFatura();
        }


        public void CalcularFatura()
        {
            if (Locacao.HorasLocadas() < 12)
            {
                ValorLocacao = Locacao.HorasLocadas() * Locacao.ValorPorHora;
                TotalAPagar = ValorLocacao + ValorImposto;
            }
            else{
                ValorLocacao = Locacao.DiasLocados() * Locacao.ValorDiario;
                TotalAPagar = ValorLocacao + ValorImposto;
            }
        }


    }
}
