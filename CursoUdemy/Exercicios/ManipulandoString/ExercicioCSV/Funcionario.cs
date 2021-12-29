using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ManipulandoString.ExercicioCSV
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
