using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Classes.Lista
{
    public class Funcionario
    {
        public int id;
        public string nome;
        public double salario;

        public Funcionario(int id, string nome, double salario)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
        }


        public void AumentarSalario(double porcentagemDeAumento)
        {
            this.salario += (porcentagemDeAumento * this.salario) / 100;
        }

    }
}
