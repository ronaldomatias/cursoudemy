using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios
{
    public class Strings
    {
        public void teste()
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper(); // TRANSFORMAR EM MAIUSCULAS
            string s2 = original.ToLower(); // TRANSFORMAR EM MINUSCULAS
            
            string s3 = original.Trim(); // REMOVER ESPAÇOS EM BRANCO DAS EXTREMIDADES

            string s4 = original.Substring(3); //CORTAR STRING A PARTIR DA POSIÇÃO 3 EM DIANTE
            string s5 = original.Substring(3, 5); //CORTAR STRING A PARTIR DA POSIÇÃO 3 ATÉ 5 POSICOES ADIANTE

            string s6 = original.Replace('a', 'x'); // CONVERTER LETRAS a EM LETRAS x
            string s7 = original.Replace("abc", "xy"); // CONVERTER LETRAS abc EM LETRAS xy

            bool b1 = String.IsNullOrEmpty(original); // STRING É NULA OU VAZIA?
            bool b2 = String.IsNullOrWhiteSpace(original); // STRING É NULA OU TEM APENAS ESPAÇOS EM BRANCO?

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }

        public void teste2()
        {
            // FUNCAO string.Split separa as palavras da frase e armazena em um vetor;

            string frase = "The quick brown fox jumps over the lazy dog.";
            string[] palavras = frase.Split(' '); 

            foreach (string s in palavras)
            {
                System.Console.WriteLine($"{s}");
            }
        }
    }
}
