using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Interfacee
{
    internal class ImpostoDoBrasil : Imposto
    {

        public double TaxaImposto(double valorLocacao)
        {
            if(valorLocacao < 100)
            {
                return 0.2 * valorLocacao;
            }
            else
            {
                return 0.15 * valorLocacao;
            }
        }


    }
}
