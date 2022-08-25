using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClassePaiClasseFilha
{
    internal class Aluno : Pessoa
    {
        String Registro;
        String Matricula;

        public Aluno(string nome, DateTime datanasc, string cpf, string registro, string matricula) : base(nome, datanasc, cpf)
        {
            Registro = registro;
            Matricula = matricula;

        }
        
        public Aluno()
        {

        }

        public void setRegistro()
        {
            Console.WriteLine("\nDigite o número do registro(RA) do aluno: ");
            this.Registro = Console.ReadLine(); 
        }
         public void getRegistro()
        {
            Console.Write("\nRegistro do aluno: " + this.Registro);
        }

        public void setMatricula()
        {
            Console.WriteLine("\nInforme a data da matrícula do aluno: ");
            this.Matricula = Console.ReadLine();
        }

        public void getMatricula()
        {
            Console.Write("\nData de matrícula do aluno: " + this.Matricula);
        }
        public override string ToString()
        {
            return base.ToString() + "\nRegistro: " + this.Registro + "\nData de Matrícula: " + this.Matricula;
        }
        public void CadastrarAluno()
        {
            setNome();
            setDataNasc();
            setCpf();
            setRegistro();
            setMatricula();

        }
        public void ImprimirAluno()
        {
            getNome();
            getDataNasc();
            getCpf();
            getRegistro();
            getMatricula();
        }

    }
}