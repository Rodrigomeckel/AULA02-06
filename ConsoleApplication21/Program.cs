using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dinheiro = new double[5];
            int i = 0;
            string opcao = "S";
            string receber;

            do
            {
                if (i <= 4)
                {
                    Console.WriteLine("");
                    Console.Write("Digite o dinheiro via teclado: ");
                    Double.TryParse(Console.ReadLine(), out dinheiro[i]);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vetor cheio!");
                    Console.WriteLine("Impossível armazenar!");
                    Console.WriteLine("");
                }
                i++;

                Console.WriteLine("Deseja digitar novamente?");
                Console.WriteLine("");
                Console.Write(">S< - SIM | NÃO >N<    ");
                Console.WriteLine("");
                opcao = Console.ReadLine();
            }
            while (opcao.ToUpper() == "S");

            Console.WriteLine("");
            Console.WriteLine("Deseja ver os TODOS números digitados?");
            Console.WriteLine("");
            Console.Write(">S< - SIM | NÃO >N<    ");
            Console.WriteLine("");
            receber = Console.ReadLine();

            if (receber.ToUpper() == "S")
            {
                int lista = 0;
                for (lista = 0; lista <= i - 1; lista++)
                {
                    
                    Console.WriteLine(dinheiro[lista].ToString("c"));
                }
                Console.Write("");
                Console.WriteLine("");
                Console.Write("aperte ENTER para finalizar");
                Console.ReadKey();
            }
            else if (receber.ToUpper() == "N")
            {
                Console.Write(""); 
                Console.WriteLine("");
                Console.Write("aperte ENTER para finalizar");
                Console.ReadKey();
            }
            else if (receber.ToUpper() != "S" || receber.ToUpper() != "N")
            {
                Console.Write("");
                Console.Write("Desculpe!");
                Console.Write("Letra não entendida!");
                Console.Write("Feche e abra o programa novamente!");
                Console.Write("");
                Console.Write("aperte ENTER para finalizar");
                Console.ReadKey();
            }
        }
    }
}
