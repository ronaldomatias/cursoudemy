using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoUdemy.Exercicios.Polimorfismo;

namespace CursoUdemy.Exercicios.Polimorfismo
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        // ATRIBUTOS
        public double DespezaAdicional { get; set; }


        // CONSTRUTORES
        public FuncionarioTerceirizado(string nome, double horasTrabalhadas, double valorPorHora, double despezaAdicional) :base(nome, horasTrabalhadas, valorPorHora)
        {
            this.DespezaAdicional = despezaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (DespezaAdicional * 1.1);
        }

        




    }
}
