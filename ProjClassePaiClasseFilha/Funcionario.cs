using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClassePaiClasseFilha
{
    internal class Funcionario : Pessoa
    {
        String NumPis;
        String Salario;
        String Setor;

        public Funcionario(string nome, DateTime datanasc, string cpf, string numero_pis, string salario, string setor) : base(nome, datanasc, cpf)
        {
            this.NumPis = numero_pis;
            this.Salario = salario;
            this.Setor = setor;
        }

        public Funcionario()
        {

        }

        public void setNumPis()
        {
            Console.WriteLine("\nInforme o Número de Pis do funcionário: ");

            this.NumPis = Console.ReadLine();
        }

        public void getNumPis()
        {
            Console.WriteLine("\nNome do funcionário: " + this.NumPis);

        }

        public void setSalario()
        {
            Console.WriteLine("\nInforme o salário do funcionário: ");

            this.Salario = Console.ReadLine();
        }

        public void getSalario()
        {
            Console.WriteLine("\nSalário do funcionário: " + this.Salario);

        }

        public void setSetor()
        {
            Console.WriteLine("\nInforme o setor do funcionário: ");

            this.Setor = Console.ReadLine();
        }

        public void getSetor()
        {
            Console.WriteLine("\nSetor do funcionário: " + this.Setor);

        }

        public void CadastrarFuncionario()
        {
            setNome(); o
            setDataNasc();
            setCpf();
            setNumPis();
            setSalario();
            setSetor();
        }
        public void ImprimirFuncionario()
        {
            getNome();
            getCpf();
            getDataNasc();
            getNumPis();
            getSalario();
            getSetor();
        }

        public override string ToString()
        {
            return base.ToString() + "\nNúmero de Pis: " + NumPis + "\nSalário: " + Salario + "\nSetor: " + Setor;
        }
    }
}
