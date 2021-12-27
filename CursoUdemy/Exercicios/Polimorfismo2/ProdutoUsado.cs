using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo2
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            this.DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {   
            return Nome +" "+ Preco +" "+ DataFabricacao ;
        }
    }
}
