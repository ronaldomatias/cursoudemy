using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee.ProblemaDiamante
{
    internal class Print : Dispositivo, IPrint
    {
        public void Printar(string documento)
        {
            Console.WriteLine(documento);
        }

        public override void ProcessarDocumento(string documento)
        {
            Console.WriteLine(documento);
        }
    }
}
