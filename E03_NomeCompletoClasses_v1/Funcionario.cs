using System;

namespace FuncionarioDadosPessoais
{

    class Funcionario
    {

        #region Properties
        public string PrimeiroNome { get; set; }
        public string NomeMeio { get; set; }
        public string UltimoNome { get; set; }
        public string NomeCompleto { get; set; }
        #endregion

        #region Methods
        public void LerPrimeiroNome()
        {
            Console.Write("Primeiro nome: ");
            PrimeiroNome = Console.ReadLine();
        }

        public void LerNomeMeio()
        {

            Console.Write("Nome do meio: ");
            NomeMeio = Console.ReadLine();

        }

        public void LerUltimoNome()
        {

            Console.Write("Último nome: ");
            UltimoNome = Console.ReadLine();

        }

        public void GerarNomeCompleto()
        {

            if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeMeio} {UltimoNome}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = PrimeiroNome;
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeMeio}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = NomeMeio;
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{NomeMeio} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = UltimoNome;
            }
            else
            {
                NomeCompleto = "<sem nome>";
            }

        }

        public void MostrarNomeCompleto()
        {

            Console.WriteLine($"\nNome completo: {NomeCompleto}\n\n");

        }
        #endregion

    }

}
