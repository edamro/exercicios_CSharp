using System;

namespace D03_TiposDados
{

    class Program
    {

        static void Main(string[] args)
        {

            // Categorias:
            // value e reference types
            // value types: geridos na stack
            // reference types: geridos na heap (é imutável!!!)
            // value: bool + numéricos
            // reference: String + DateTime + Classes

            // sintaxe: value_type <nome> = <valor>;
            // int valor = 10;

            // sintaxe: reference_type <nome> = new reference_type();    // DateTime
            // Product produto01 = new Product();
            // produto01.Name = "Caneta";

            #region 1. Declarar variáveis
            // Value types
            byte idade;
            bool inscrito;            
            double altura;
            // Reference types
            string nome;
            DateTime data;
            DateTime hora;            
            DateTime dataHoraAtuais;    // timestamp
            DateTime dataAtual;
            DateTime dataVazia;
            #endregion

            #region 2. Atribuir valores às variáveis
            idade = 1;
            inscrito = true;    // false
            altura = 1.3;
            nome = "Pessoa";
            data = new DateTime(2021, 10, 5);
            hora = new DateTime(2021, 10, 5, 11, 1, 10);
            dataHoraAtuais = DateTime.Now;
            dataAtual = DateTime.Today;
            dataVazia = DateTime.MinValue;  // data mais pequena
            #endregion

            #region 3. Listar as variáveis
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("TIPOS DE DADOS");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Byte\t\tIdade: " + idade);
            Console.WriteLine("Boolean\t\tInscrito? " + inscrito);
            Console.WriteLine("String\t\tNome: " + nome);
            Console.WriteLine("Double\t\tAltura: " + altura);   // auto-cast 
            Console.WriteLine("DateTime\tData: " + data);
            Console.WriteLine("DateTime\tData short: " + data.ToShortDateString());
            Console.WriteLine("DateTime\tData long: " + data.ToLongDateString());
            Console.WriteLine("DateTime\tHora short: " + hora.ToShortTimeString());
            Console.WriteLine("DateTime\tHora long: " + hora.ToLongTimeString());
            Console.WriteLine("DateTime\tData e hora atuais (timestamp): " + dataHoraAtuais);
            Console.WriteLine("DateTime\tData atual: " + dataAtual.ToShortDateString());
            Console.WriteLine("DateTime\tData vazia: " + dataVazia.ToShortDateString());
            #endregion

            #region 4. Pausar a consola
            Console.ReadKey();
            #endregion            

        }

    }

}
