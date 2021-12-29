using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ManipulandoString.ExercicioCSV
{
    internal class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public int CompareTo(object obj)
        {   
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Não é possível comparar objetos de tipos diferentes");
            }

            Funcionario funcionario = obj as Funcionario;

            return Nome.CompareTo(funcionario.Nome);
        }
    }
}
