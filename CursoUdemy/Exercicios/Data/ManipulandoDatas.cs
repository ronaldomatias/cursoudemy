using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Data
{
    internal class ManipulandoDatas
    {

        public void teste1()
        {   
            // CONSTRUTORES
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //COM CONSTRUTOR KIND LOCAL
            Console.WriteLine("d1: " + d1); // O PADRÃO SEMPRE É HORARIO LOCAL
            Console.WriteLine("d1 Kind: " + d1.Kind); // MOSTRA DE ONDE É O HORÁRIO (LOCAL, UTC)
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); // MOSTRA HORARIO LOCAL
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); // MOSTRA HORARIO UNIVERSAL
            Console.WriteLine();
            //COM CONSTRUTOR KIND MUNDIAL
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            //COM CONSTRUTOR KIND INESPECIFICADO
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
        }

        public void teste2()
        {
            DateTime d1 = DateTime.Now; // DATA E HORA LOCAL ATUAL 
            DateTime d2 = DateTime.UtcNow; // DATA E HORA MUNDIAL ATUAL
            DateTime d3 = DateTime.Today; // DATA LOCAL

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // CONVERSOES DE STRING PARA DATETIME
            DateTime E1 = DateTime.Parse("2000-08-15");
            DateTime E2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime E3 = DateTime.Parse("15/08/2000");
            DateTime E4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(E1);
            Console.WriteLine(E2);
            Console.WriteLine(E3);
            Console.WriteLine(E4);
        }

        public void teste3()
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }


    }
}
