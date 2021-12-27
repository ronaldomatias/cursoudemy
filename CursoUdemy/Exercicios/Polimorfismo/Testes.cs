using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Polimorfismo
{
    internal class Testes
    {
        public void teste()
        {
            List<Funcionario> ListaFuncionarios = new List<Funcionario>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Cadastre os funcionários");
                Console.WriteLine("Funcionario é terceirizado?");
                string ehTerceirizado = Console.ReadLine();

                Console.WriteLine("Nome?");
                string nome = Console.ReadLine();

                Console.WriteLine("Horas trabalhadas?");
                double horasTrabalhadas = double.Parse(Console.ReadLine());

                Console.WriteLine("Valor por hora?");
                double valorPorHora = double.Parse(Console.ReadLine());

                if (ehTerceirizado == "n")
                {
                    ListaFuncionarios.Add(new Funcionario(nome, horasTrabalhadas, valorPorHora));
                }
                else{
                    Console.WriteLine("Despeza adicional?");
                    double despezaAdicional = double.Parse(Console.ReadLine());

                    ListaFuncionarios.Add(new FuncionarioTerceirizado(nome, horasTrabalhadas, valorPorHora, despezaAdicional));
                }
            }

            foreach (Funcionario f in ListaFuncionarios)
            {
                Console.WriteLine(f.Nome + " " + f.Pagamento());
            }
        }


    }
}
