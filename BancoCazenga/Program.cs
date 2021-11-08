using System;
using System.Globalization;

namespace BancoCazenga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char opcao = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Banco banco; 

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                banco = new Banco(conta, nome, valor);
                Console.WriteLine("Dados da conta: \n" + banco);
            }
            else
            {
                banco = new Banco(conta, nome);
                Console.WriteLine("Dados da conta: \n" + banco);
            }
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");

            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados: \n" + banco);
            Console.WriteLine( );

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: \n" + banco);
        }
    }
}
