using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Classes.Lista
{
    public class TesteLista
    {
        public void testeLista()
        {
            List<string> lista = new List<string> { "Ronaldo", "Mary", "Jane", "Jo" };
            lista.Add("Oswald");
            lista.Insert(2, "Tey"); // INSERINDO NA POSIÇÃO 2

            // BUSCAR A POSIÇÃO DA PRIMEIRA MARY DA LISTA != (FindLastIndex)
            int posicao = lista.FindIndex(x => x == "Mary");
            Console.WriteLine($"Mary está na posição: {posicao} da lista.");


            // BUSCAR PRIMEIRO ELEMENTO QUE COMEÇA COM J
            Console.WriteLine("O primeiro elemento que começa com a letra 'J' é:");
            string primeiro = lista.Find(x => x[0] == 'J');
            Console.WriteLine(primeiro);


            // BUSCAR ULTIMO ELEMENTO QUE COMEÇA COM J
            Console.WriteLine("O ultimo elemento que começa com a letra 'J' é:");
            string ultimo = lista.FindLast(x => x[0] == 'J');
            Console.WriteLine(ultimo);


            // BUSCAR TODOS ELEMENTOS QUE INICIEM COM A LETRA J
            List<string> item = lista.FindAll(x => x[0] == 'J'); 
            Console.WriteLine("Os elementos que começam com letra 'J' são:");
            foreach(string s in item)
            {
                Console.WriteLine(s);
            }


            // BUSCAR TODOS ELEMENTOS DA LISTA
            Console.WriteLine("Todos os elementos da lista são: ");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }


            // REMOVER A PARTIR DE UMA POSICAO
            Console.WriteLine("Após excluir 2 primeiros ítens: ");
            lista.RemoveRange(0, 2);
            foreach(string s in lista)
            {
                Console.WriteLine(s);
            }


            // REMOVER POR POSICAO
            Console.WriteLine("Após excluir o elemento da segunda posição: ");
            lista.RemoveAt(1);
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }


            // REMOVER ELEMENTOS QUE SATISFAÇAM A LAMBDA
            Console.WriteLine("Após remover os elementos que iniciam com a letra 'O': ");
            lista.RemoveAll(x => x[0] == 'O');
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }


            // REMOVER ELEMENTO QUE SEJA IGUAL AO DETERMINADO
            Console.WriteLine("Após remover o elemento que se chama 'Jo': ");
            lista.Remove("Jo");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }



    }
}
