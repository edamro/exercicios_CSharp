using System;

namespace D07_EstruturasCiclicas
{

    class Program
    {

        static void Main(string[] args)
        {

            #region Variáveis
            string valor1 = string.Empty, valor2 = "x", nome = "";
            #endregion            

            // Repetir até ser T/F
            #region WHILE
            Console.WriteLine("--------------------------------\nWHILE\n--------------------------------\n");

            while (valor1 != "x")
            {
                Console.Write("Para sair, escrever x: ");
                valor1 = Console.ReadLine();
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region DO...WHILE
            Console.WriteLine("--------------------------------\nDO...WHILE\n--------------------------------\n");

            do
            {
                Console.Write("Para sair, escrever x: ");
                valor2 = Console.ReadLine();
            } while (valor2 != "x");

            Console.ReadKey();
            Console.Clear();
            #endregion

            // Repetir x nº de vezes
            #region FOR v1
            Console.WriteLine("--------------------------------\nFOR v1\n--------------------------------\n");

            // Repetir 4 vezes: de 1 até 4
            // i++  --> i = i + 1       --> incrementar em 1
            // 0 = 0 + 1 --> 1
            // 1 = 1 + 1 --> 2
            // 2 = 2 + 1 --> 3
            // 3 = 3 + 1 --> 4

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Número " + i);
            }

            Console.WriteLine();

            // Repetir 4 vezes: de 4 até 1
            // i--  --> i = i - 1
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Número " + i);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region FOR v2
            Console.WriteLine("--------------------------------\nFOR v2\n--------------------------------\n");

            Console.WriteLine("Escreve o nome de 4 formandos\n");

            for (int i = 1; i < 5; i++)
            {
                Console.Write("Formando nº " + i + ": ");
                nome = Console.ReadLine();
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region FOR v3
            Console.WriteLine("--------------------------------\nFOR v3 - TABUADA DOS 7\n--------------------------------\n");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("7 x " + i + " = " + 7 * i);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region FOREACH
            // Primeiro, ver as estruturas de dados: arrays e collections
            /*
            foreach (var item in array/collection)
            {

            }
            */
            #endregion

        }

    }

}
