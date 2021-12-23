using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Enumeradores.ExercicioEnum
{
    internal class Teste
    {   
        public void teste()
        {
            Trabalhador trabalhador = new Trabalhador();
            CadastrarTrabalhador(trabalhador);

            CadastrarContratos(trabalhador);

            Console.WriteLine("Deseja ver o salário de qual mês?");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine(trabalhador.ObterMontanteContratosMensal(mes));
            Console.WriteLine(trabalhador.ListaContratos.First());
        }

        public Trabalhador CadastrarTrabalhador(Trabalhador trabalhador)
        {
            Console.WriteLine("Nome: ");
            trabalhador.Nome = Console.ReadLine();

            Console.WriteLine("Cargo: [1]JUNIOR , [2] MID_LEVEL, [3] SENIOR ");
            Cargo cargo = (Cargo)Enum.Parse(typeof(Cargo), Console.ReadLine());
            trabalhador.Cargo = cargo;

            Console.WriteLine("Salario: ");
            trabalhador.SalarioBase = double.Parse(Console.ReadLine());

            return trabalhador;
        }

        public void CadastrarContratos(Trabalhador trabalhador)
        {
            for (int i = 0; i < 3; i++)
            {
                Contrato contrato = new Contrato();
                Console.WriteLine("Insira as informações do contrato: ");

                Console.WriteLine("Valor por hora: ");
                contrato.ValorPorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Horas trabalhadas: ");
                contrato.HorasTrabalhadas = double.Parse(Console.ReadLine());

                Console.WriteLine("Data do contrato: ");
                contrato.Data = DateTime.Parse(Console.ReadLine());

                trabalhador.addContrato(contrato);
            }
        }

    }
}

