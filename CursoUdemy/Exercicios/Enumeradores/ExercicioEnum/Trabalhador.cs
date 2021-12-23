using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Exercicios.Enumeradores.ExercicioEnum
{
    internal class Trabalhador
    {
        //ATRIBUTOS
        private string nome;
        private Cargo cargo;
        private double salarioBase;
        private List<Contrato> listaContratos;

        //CONSTRUTOR
        public Trabalhador()
        {
            listaContratos = new List<Contrato>();
        }


        // MÉTODOS
        public void addContrato(Contrato contrato)
        {
            listaContratos.Add(contrato);
        }
        
        public double ObterMontanteContratosMensal(int mesPesquisado)
        {
            List<Contrato> listaContratosDoMes = new List<Contrato>();
            double montanteContratosMensal = 0;

            foreach (Contrato contrato in listaContratos)
            {
                if (contrato.Data.Month == mesPesquisado)
                {
                    montanteContratosMensal += contrato.valorDoContrato();
                }
            }

            return montanteContratosMensal + salarioBase;
        }


        // METODOS GET E SET
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public List<Contrato> ListaContratos
        {
            get { return listaContratos; }
        }

    }
}
