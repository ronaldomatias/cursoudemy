using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Genericss.Restricoes
{
    class GerarValorMaximo
    {

        public T ObterMaiorValor<T>(List<T> lista) where T : IComparable
        {
            if(lista.Count == 0)
            {
                throw new Exception();
            }

            T maior = lista[0];
            for(int i=0; i < lista.Count; i++)
            {
                if (lista[i].CompareTo(maior) > 0)
                {
                    maior = lista[i];
                }
            }

            return maior;
        }
    }
}
