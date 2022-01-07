using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{

    class Program
    {

        static void Main(string[] args)
        {

            // Instanciar um objeto da classe Funcionario
            Funcionario funcionario01 = new Funcionario();

            // Executar os métodos
            funcionario01.LerNome();
            funcionario01.LerEmail();
            funcionario01.EscreverMensagem();

            // Pausar
            Console.ReadKey();

        }

    }

}
