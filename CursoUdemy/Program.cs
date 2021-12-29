using CursoUdemy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoUdemy.Exercicios.Interfacee;

namespace CursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2015, 05, 10);

            Console.WriteLine(dt.Date.AddMonths(2));

            Console.WriteLine(dt);
            Console.Read();
        }
  
        
    }
}
