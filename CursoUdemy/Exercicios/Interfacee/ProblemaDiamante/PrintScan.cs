using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee.ProblemaDiamante
{
    internal class PrintScan : Dispositivo, IScanner, IPrint
    {
        public void Printar(string documento)
        {
            Console.WriteLine(documento);
        }

        public override void ProcessarDocumento(string documento)
        {
            Console.WriteLine(documento);
        }

        public void Scannear(string documento)
        {
            Console.WriteLine(documento);
        }
    }
}
