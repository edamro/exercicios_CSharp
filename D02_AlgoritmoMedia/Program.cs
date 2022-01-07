using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

//Implementar o algoritmo da média final

namespace D02_AlgoritmoMedia
{
 
    class Program
    {
    
        static void Main(string[] args)
        {

            // Declarar as variáveis
            double nota1, nota2, media;

            // Escrever e ler a nota1
            Console.Write("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            // Escrever e ler a nota2
            Console.Write("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // Calcular a média
            media = (nota1 + nota2) / 2;

            // Escrever linha vazia
            Console.WriteLine();

            // Escrever a média
            // Console.WriteLine("Média = " + media);                   // auto convert
            Console.WriteLine("Média = " + Convert.ToString(media));    // convert manual

            // Escrever linha vazia
            Console.WriteLine();

            // Verificar se passou ou reprovou
            if (media >= 9.5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            { 
                Console.WriteLine("Reprovado");
            }
            
            // Pausar a consola
            Console.ReadKey();

        }

    }

}
