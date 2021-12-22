using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Classes.Lista
{   


    // TESTE PARA BUSCAR FUNCIONARIO POR ID E AUMENTAR SEU SALÁRIO
    public class TesteExercicioLista
    {
        List<Funcionario> listaFunc;

        public void teste()
        {
            cadastrarFuncionarios();

            escolherFuncionarioEPorcentagemDeAumento();

            foreach (Funcionario ff in listaFunc)
            {
                Console.WriteLine("{0}, {1}, {2}", ff.id, ff.nome, ff.salario);
            }
        }

        public void cadastrarFuncionarios()
        {
            listaFunc = new List<Funcionario>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o NOME: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira o SALARIO: ");
                double salario = double.Parse(Console.ReadLine());

                listaFunc.Add(new Funcionario(id, nome, salario));
            }
        }

        public void escolherFuncionarioEPorcentagemDeAumento()
        {
            Console.WriteLine("Insira o ID do funcionário que terá aumento: ");
            int ide = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());

            aumentarSalarioFuncionario(ide, porcentagem);
        }

        public void aumentarSalarioFuncionario(int ide, double porcentagem)
        {
            Funcionario f = listaFunc.Find(x => x.id == ide);

            if (f == null){
                Console.WriteLine("ID não existe!");
            }
            else{
                f.AumentarSalario(porcentagem);
            }
        }

    }
}
