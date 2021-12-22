using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Enumeradores.ExercicioEnum
{
    public class Contrato
    {
        // ATRIBUTOS
        private DateTime data;
        private double valorPorHora;
        private double horasTrabalhadas;


        // METODOS
        public double valorDoContrato()
        {
            return horasTrabalhadas * valorPorHora;
        }


        // METODOS GET E SET
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double ValorPorHora
        {
            get { return valorPorHora; }
            set { valorPorHora = value; }
        }
        public double HorasTrabalhadas
        {
            get { return horasTrabalhadas; }
            set { horasTrabalhadas = value; }
        }
        





    }








}
