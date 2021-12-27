using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo2
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) :base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public override string EtiquetaPreco()
        {
            return Nome +" "+ PrecoTotal() +" "+ TaxaAlfandega;
        }

        public double PrecoTotal()
        {
           return Preco += TaxaAlfandega;
        }

    }
}
