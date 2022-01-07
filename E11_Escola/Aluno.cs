using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11_Escola
{
    class Aluno
    {

        #region Properties
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int NumMorada { get; set; }
        public int CodigoPostal { get; set; }
        public int DiaNascimento { get; set; }
        public string MesNascimento { get; set; }
        public int AnoNascimento { get; set; }
        //public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Constructors
        public Aluno()
        {
            Nome = string.Empty;
            Morada = string.Empty;
            NumMorada = 0;
            CodigoPostal = 0;
            DiaNascimento = 0;
            MesNascimento = string.Empty;
            AnoNascimento = 0;
            Telefone = string.Empty;
        }
        #endregion

        #region Methods
        public void Criar() // inserir todos os dados pela console
        {
            Console.Clear();

            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Morada: ");
            Morada = Console.ReadLine();

            Console.Write("Número: ");
            NumMorada = Convert.ToInt16(Console.ReadLine());

            Console.Write("Código Postal: ");
            CodigoPostal = Convert.ToInt16(Console.ReadLine());

            Console.Write("Dia do Nascimento: ");
            DiaNascimento = Convert.ToInt16(Console.ReadLine());

            Console.Write("Mês do Nascimento: ");
            MesNascimento = Console.ReadLine();

            Console.Write("Ano do Nascimento: ");
            AnoNascimento = Convert.ToInt16(Console.ReadLine());

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();

        }

        public void Listar()
        {

            Console.Clear();

            Console.WriteLine($"------------------------\nDados do Aluno\n------------------------");

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Morada: {Morada}\t Número: {NumMorada}");
            Console.WriteLine($"Código Postal: {CodigoPostal}");
            Console.WriteLine($"Data de Nascimento: {DiaNascimento} / {MesNascimento} / {AnoNascimento}");
            Console.WriteLine($"Telefone: {Telefone}");
            #endregion
            Console.ReadKey();
        }
    }
}
