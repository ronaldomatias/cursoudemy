using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Classes.NewFolder1
{
    public class Construtores
    {
        int atributo1;
        int atributo2;
        int atributo3;


        public Construtores(int atributo3)
        {
            this.atributo3 = atributo3;
        }

        public Construtores(int atributo1, int atributo2, int atributo3) : this(atributo3) // essa parte faz com que nao precise escrever
                                                                                           // " atributo3 = atributo3" no escopo desse metodo;
        {
            this.atributo1 = atributo1;
            this.atributo2 = atributo2;
        }

        public Construtores()
        {
        }
    }
}
