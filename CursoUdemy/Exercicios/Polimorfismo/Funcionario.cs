using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo
{
    internal class Funcionario
    {
        // ATRIBUTOS
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }


        // CONSTRUTORES
        public Funcionario()
        {
        }
        public Funcionario(string nome, double horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }
    
    
        // METODOS
        public virtual double Pagamento()
        {
            double valorPagamento = HorasTrabalhadas * ValorPorHora;

            return valorPagamento;
        }




    }
}
