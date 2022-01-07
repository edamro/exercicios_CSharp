using System;
using System.Text;

namespace D05_ManipulacaoDados
{

    class Program
    {

        static void Main(string[] args)
        {

            #region Variáveis
            string area = "Informática";
            string categoria = "Linguagem de programação";
            string curso = "Microsoft C# Iniciação";
            string cursoCompleto1, cursoCompleto2;

            cursoCompleto1 = string.Join("; ", area, categoria, curso);
            cursoCompleto2 = string.Concat(area, " / ", categoria, " - ", curso);

            DateTime timestamp = DateTime.Now;

            
            #endregion

            #region String
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("STRING");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Maiúsculas: " + curso.ToUpper());
            Console.WriteLine("\n1ª palavra: " + curso.Substring(0, 9));
            Console.WriteLine("\nConcatenar com +: \n\t" + area + "\n\t" + categoria + "\n\t" + curso);
            Console.WriteLine("\nConcatenar com string.Join(): \n\t" + cursoCompleto1);
            Console.WriteLine($"\nConcatenar com string interpolation: \n\t {cursoCompleto2}");
            #endregion

            #region DateTime
            Console.WriteLine("\n\n\n----------------------------------------------------");
            Console.WriteLine("DATETIME");
            Console.WriteLine("----------------------------------------------------");
            // Para formatar uma data/hora temos de converter para string
            Console.WriteLine(timestamp); // Qual o formato original?
            Console.WriteLine("Data atual (dd-MM-yyyy): " + timestamp.ToString("dd-MM-yyyy"));
            Console.WriteLine("Data atual (dd-MMM-yyyy): " + timestamp.ToString("dd-MMM-yyyy"));
            Console.WriteLine("Data atual (dd-MMMM-yyyy): " + timestamp.ToString("dd-MMMM-yyyy"));
            Console.WriteLine("Data atual (dd-MMMM-yy): " + timestamp.ToString("dd-MMMM-yy"));
            Console.WriteLine("Horas atuais (hh:mm): " + timestamp.ToString("hh:mm"));
            Console.WriteLine("Ano atual: " + timestamp.Year);
            Console.WriteLine("Mês atual: " + timestamp.Month);
            Console.WriteLine("Dia atual: " + timestamp.Day);
            Console.WriteLine("Hora atual: " + timestamp.Hour);
            Console.WriteLine("Minutos atuais: " + timestamp.Minute);
            Console.WriteLine("Mais 10 minutos: " + timestamp.AddMinutes(10).ToString("mm"));
            Console.WriteLine("Segundos atuais: " + timestamp.Second);
            Console.WriteLine("Hora futura: " + timestamp.AddHours(1).ToShortTimeString());
            Console.WriteLine("Hora futura: " + timestamp.AddHours(1).ToString("hh"));
            Console.WriteLine("Hora futura: " + timestamp.AddHours(1).ToString("HH"));
            #endregion

            Console.ReadKey();

        }

    }

}
