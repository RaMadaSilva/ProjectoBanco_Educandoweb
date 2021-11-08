using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace BancoCazenga
{
    class Banco
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular; 

        }

        public Banco(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Saldo = Depositar(depositoInicial); 
        }

        public double  Depositar(double valor)
        {
            return Saldo += valor; 
        }

        public void Sacar(double valor)
        {
            Saldo -=valor + 5.00; 

        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + " , Tutular: " + NomeTitular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
