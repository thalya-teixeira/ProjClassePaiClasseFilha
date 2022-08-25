using System;

namespace ProjClassePaiClasseFilha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Aluno alu = new Aluno();
            Funcionario func = new Funcionario();


            p1.CadastrarPessoa();
            p1.ImprimirPessoa();
            Console.ReadKey();

            alu.CadastrarAluno();
            alu.ImprimirAluno();
            Console.ReadKey();

            func.CadastrarFuncionario();
            func.ImprimirFuncionario();
            Console.ReadKey();

          
        }
    }
}
