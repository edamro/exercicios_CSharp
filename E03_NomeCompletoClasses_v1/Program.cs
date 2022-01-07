using System;

namespace FuncionarioDadosPessoais
{

    class Program
    {

        static void Main(string[] args)
        {

            Funcionario funcionario01 = new Funcionario();

            funcionario01.LerPrimeiroNome();
            funcionario01.LerNomeMeio();
            funcionario01.LerUltimoNome();
            funcionario01.GerarNomeCompleto();
            funcionario01.MostrarNomeCompleto();

            Console.ReadKey();

        }

    }

}
