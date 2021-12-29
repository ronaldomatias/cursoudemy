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
        public double TotalPagamento { get; set; }
        public double ValorLocacao { get; set; }


        public Fatura(Locacao locacao, Imposto imposto)
        {
            Locacao = locacao;
            Imposto = imposto;

            DeterminarValorLocacao();
            TotalAPagar();
        }

        public void DeterminarValorLocacao()
        {
            if (Locacao.HorasLocadas() < 12)
            {
                ValorLocacao = Locacao.HorasLocadas() * Locacao.ValorPorHora;
            }
            else
            {
                ValorLocacao = Locacao.DiasLocados() * Locacao.ValorDiario;
            }
        }

        public void TotalAPagar()
        {
            if (ValorLocacao > 100)
            {
                TotalPagamento = ValorLocacao + Imposto.TaxaImposto(ValorLocacao);
            }
            else
            {
                TotalPagamento = ValorLocacao + Imposto.TaxaImposto(ValorLocacao);
            }
        }

        
    
    }





}
