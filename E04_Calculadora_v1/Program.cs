using System;

namespace Calculadora
{

    class Program
    {

        static void Main(string[] args)
        {

            // Tratamento de erros
            try
            {

                // classe nomeObjeto = new Constructor();

                CalculadoraSimples calculo01 = new CalculadoraSimples();            // 1º

                CalculadoraSimples calculo02 = new CalculadoraSimples(10, 2, "+");  // 3º

                CalculadoraSimples calculo03 = new CalculadoraSimples(30, 5);       // 2º

                calculo01.MostrarMenu();
                calculo01.LerValor1();
                calculo01.LerValor2();
                calculo01.LerOperacao();

                if (calculo01.ValidarOperacao())    // se for true
                {
                    calculo01.RealizarOperacao();
                    calculo01.EscreverResultado();
                }
                else
                {
                    Console.WriteLine("\nNão foi possível realizar a operação.\n\n");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\n\nAtenção ao argumento.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n\nAtenção ao formato do número.");
            }            
            catch (Exception)
            {
                Console.WriteLine("\n\nOcorreu um erro.");
                // throw;
                // Console.WriteLine(erro.Message);     // serve para logar o erro
            }

            Console.ReadKey();

        }

    }

}
