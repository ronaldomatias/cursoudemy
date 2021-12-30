using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Genericss.Restricoes
{
    class GerarValorMaximo
    {
        List<int> Lista;

        public int ObterMaiorValor(List<int> lista)
        {
            this.Lista = lista;

            if(lista.Count == 0)
            {
                throw new Exception();
            }

            int maior = lista[0];
            for(int i=0; i < lista.Count; i++)
            {
                if (lista[i] > maior)
                {
                    maior = lista[i];
                }
            }

            return maior;
        }
    }
}
