using System;

namespace D08_EstruturasDados
{

    class Program
    {

        static void Main(string[] args)
        {

            // Ativar o suporte a Unicode na consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.WriteLine("Há receção código à");

            #region Modo clássico com variáveis
            /*
            string nome01, nome02, nome03, nome04, nome05, nome06, nome07, nome08, nome09, nome10, nome11;

            nome01 = "Milena";
            nome02 = "Pedro";
            nome03 = "Miguel";
            nome04 = "António";
            nome05 = "Erika";
            nome06 = "Igor";
            nome07 = "Fábio";
            nome08 = "Rui";
            nome09 = "Domingos";
            nome10 = "Márcia";
            nome11 = "Joel";

            Console.WriteLine(nome01);
            Console.WriteLine(nome02);
            Console.WriteLine(nome03);
            Console.WriteLine(nome04);
            Console.WriteLine(nome05);
            Console.WriteLine(nome06);
            Console.WriteLine(nome07);
            Console.WriteLine(nome08);
            Console.WriteLine(nome09);
            Console.WriteLine(nome10);
            Console.WriteLine(nome11);
            */
            #endregion

            /*
                Modo otimizado com estruturas de dados
                Vetor ou single-dimensional array: várias linhas x 1 coluna
                Matriz ou multi-dimensional array: várias linhas x várias colunas
            */

            #region VETOR - Criar
            // Vetor com 2 elementos: 1º dimensionar, 2º atribuir
            string[] areas = new string[2];
            areas[0] = "C#";
            areas[1] = "T-SQL";
            // areas[2] = "PBI";   // erro

            // Vetor com 3 elementos
            string[] pessoas = new string[4]    // 1 vetor é 1 objeto
            {
                "Ana",      // linha 0
                "Milena",   // linha 1
                "Amélia",   // linha 2
                "asdadsad"  // linha 3
            };

            // Vetor dinâmico, sem dimensão inicial
            string[] localidades = new string[]
            {
                "Gaia",      // linha 0
                "Porto",     // linha 1
                "Espinho"    // linha 2
            };


            // Declarar e atribuir valores ao array
            string[] menu = new string[]
            {
                "[+]",
                "[-]",
                "[*]",
                "[/]"
            };

            string[] paises1 = new string[] { "PT", "BR", "ES" };

            string[] paises2 = new string[]
            {
                "PT",
                "BR",
                "ES"
            };

            string[] paises3 =
            {
                "PT",
                "BR",
                "ES"
            };

            int[] numeros = new int[]
            {
                1,
                2,
                3,
            };

            DateTime[] datas = new DateTime[]
            {
                new DateTime(2021, 10, 11),
                new DateTime(2021, 10, 12),
                new DateTime(2021, 10, 13),
            };
            #endregion

            #region VETOR - Listar
            Console.WriteLine("--------------------------------\nVETOR - Listar PESSOAS\n--------------------------------\n");

            // Mostrar o 1º elemento do vetor
            Console.Write("\nMostrar a 1ª pessoa: ");
            Console.WriteLine(pessoas[0]);  // Ana

            // Listar o vetor pessoas dizendo qual o nº de linhas
            Console.WriteLine("\nFor com nº de linhas");
            for (int i = 0; i < 2; i++) // 
            {
                Console.WriteLine(pessoas[i]);
            }

            // Listar o vetor formandos usando a propriedade Length
            Console.WriteLine("\nFor com length");

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i]);
            }
            
            Console.WriteLine("\nForeach");

            // Listar o vetor formando com Foreach
            foreach (string pessoa in pessoas)  // Usar var se não soubermos o data type
            {
                Console.WriteLine(pessoa);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------------------------\nVETOR - Listar PAISES\n--------------------------------\n");

            foreach (string pais in paises1)
            {
                Console.Write(pais + "\t");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region MATRIZ - Criar
            // Matriz com 6 elementos: 2 linhas x 3 colunas (nome, localidade, país)
            string[,] clientes = new string[3, 3]
            {
                {   // 1ª linha
                    "Ana",       // [0,0]
                    "São Paulo", // [0,1]
                    "BR"         // [0,2]
                },
                {   // 2ª linha
                    "Milena",   // [1,0]
                    "Aveiro",   // [1,1]
                    "PT"        // [1,2]
                },
                {   // 3ª linha
                    "aa",
                    "bb",
                    "cc"
                }
            };

            // Matriz com indicação dos elementos   (melhor: dictionary collection --> pares de chave/valor)
            string[,] produtos = new string[3, 2];
            produtos[0, 0] = "RA";
            produtos[0, 1] = "Rato";
            produtos[1, 0] = "PC";
            produtos[1, 1] = "Computador";
            produtos[2, 0] = "IM";
            produtos[2, 1] = "Impressora";

            // Matriz dinâmica : 4 linhas x 2 colunas
            string[,] cursos = new string[,]
            {
                { "Programação", "C#", "qaz" },
                { "Programação", "Java", "" },
                { "Base de Dados", "T-SQL", "sdsda" },
                { "Base de Dados", "PL/SQL", "sdsadas" }
            };
            #endregion

            #region MATRIZ - Listar            
            Console.WriteLine("--------------------------------\nMATRIZ - Listar 1 -  FOREACH\n--------------------------------\n");

            foreach (string cliente in clientes)    // para cada cliente da matriz clientes
            {
                Console.WriteLine(cliente);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------------------------\nMATRIZ - Listar 2 - FOREACH\n--------------------------------\n");

            foreach (string produto in produtos)
            {
                Console.WriteLine(produto);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------------------------\nMATRIZ - Listar 3 - FOREACH\n--------------------------------\n");

            foreach (string curso in cursos)
            {
                Console.WriteLine(curso);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------------------------\nMATRIZ - Listar 4 - FOR encadeados\n--------------------------------\n");

            // string[3,3]: 1ª dimensão = linhas; 2ª dimensão = colunas

            // Anda nas linhas
            for (int l = 0; l < clientes.GetLength(0); l++)
            {
                // Anda nas colunas
                for (int c = 0; c < clientes.GetLength(1); c++)
                {
                    Console.Write(clientes[l, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            #endregion

        }

    }

}

