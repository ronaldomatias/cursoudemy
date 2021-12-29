using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee.ProblemaDiamante
{
    internal class Scan : Dispositivo, IScanner
    {
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
