using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo2
{
    internal class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            return Nome + " " + Preco;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produto))
            {
                throw new ArgumentException("Você não está comparando um produto!");
            }

            Produto outro = obj as Produto;

            return Preco.CompareTo(outro.Preco);
        }
    }
}
