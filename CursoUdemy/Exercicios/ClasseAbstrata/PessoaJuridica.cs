using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ClasseAbstrata
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }


        public PessoaJuridica(string nome, double rendaAnual, int numFunc) : base(nome, rendaAnual)
        {
            this.NumFuncionarios = numFunc;
        }


        public override double ImpostoRenda()
        {
            double impostos;
            if (NumFuncionarios <= 10)
            {
                impostos = RendaAnual * 0.16;
            }
            else
            {
                impostos = RendaAnual * 0.14;
            }

            return impostos;
        }
    }
}
