using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ClasseAbstrata
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            this.GastosComSaude = gastosComSaude;
        }

        public override double ImpostoRenda()
        {
            double impostos;
            if (RendaAnual < 20000)
            {
                impostos = RendaAnual * 0.15;
                impostos -= GastosComSaude * 0.5;
            }
            else
            {
                impostos = RendaAnual * 0.25;
                impostos -= GastosComSaude * 0.5;
            }

            return impostos;
        }
   
    
    
    
    }
}
