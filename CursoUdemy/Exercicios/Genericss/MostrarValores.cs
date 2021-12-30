using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoUdemy.Exercicios.Genericss;

namespace CursoUdemy.Exercicios.Genericss
{
    class MostrarValores <T>
    {
        public T[] lista = new T[10];
        int contador = 0;

        public MostrarValores()
        {
        }

        public void AddValor(T valor)
        {
            if(contador == 10)
            {
                throw new InvalidOperationException();
            }

            lista[contador] = valor;
            contador++;
        }

        public T PrimeiroValor()
        {   
            if (contador == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return lista[0];
        }
    
        public void ImprimirLista()
        {
            foreach (T i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }

}
