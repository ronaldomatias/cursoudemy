using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee.ProblemaDiamante
{
    abstract class Dispositivo
    {
        public int NumeroSerial { get; set; }

        public abstract void ProcessarDocumento(string documento);
    }
}
