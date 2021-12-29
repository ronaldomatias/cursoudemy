using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.ManipulandoString.ExercicioCSV
{
    internal class Testes
    {

        public void teste()
        {
            string endereco = @"C:\Users\ronal\OneDrive\Documentos\emails.csv";

            using (StreamReader sr = File.OpenText(endereco))
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                while (!sr.EndOfStream)
                {
                    string[] vetor = sr.ReadLine().Split(';');
                    funcionarios.Add(new Funcionario(vetor[0], vetor[1]));
                }

                funcionarios.Sort();
                foreach(Funcionario f in funcionarios)
                {
                    Console.WriteLine(f.Nome +" "+ f.Email);
                }
                

            }
        }

        }
    }
