using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClassePaiClasseFilha
{
    internal class Pessoa
    {
        //atributos
        protected String Nome;
        protected DateTime DataNasc;
        protected String Cpf;

        //metodo construtor
        
        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNasc, string cpf)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Cpf = cpf;
        }

        public void setNome()
        {
            Console.WriteLine("\nInforme o seu nome: ");

            this.Nome = Console.ReadLine();
        }

        public void getNome()
        {
            Console.WriteLine("\nNome: " + this.Nome);
        }

        public void setDataNasc()
        {
            Console.WriteLine("\nInforme a sua data de nascimento: ");

            this.DataNasc = DateTime.Parse(Console.ReadLine());
        }

        public void getDataNasc()
        {
            Console.WriteLine("\nA data de nascimento é: " + this.DataNasc.ToShortDateString()); //toShortDateString é para reverter só a data curta(DD/MM/AA) pois sem isso só com DateTime ele pega as horas/min/seg
        }
         

        public void setCpf()
        {
            Console.WriteLine("\nInforme o CPF: ");

            this.Cpf = Console.ReadLine();
        }

        public void getCpf()
        {
            Console.WriteLine("\nCPF: " + this.Cpf);
        }

        public override String ToString()
        {
            return "\nNome: " + this.Nome + "\nData de Nascimento: " + this.DataNasc.ToShortDateString() + "\nCPF: " + this.Cpf;
        }

        public void CadastrarPessoa()
        {
            setNome();
            setDataNasc();
            setCpf();
        }

        public void ImprimirPessoa()
        {
            getNome();
            getDataNasc();
            getCpf();
        }
    }
}
