using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_gft_dotnet.Desafio_1
{
    public class ContaBancaria
    {
        private int numeroConta { get; set; }

        private string titular { get; set; }

        private double saldo { get; set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = 0;

            Console.WriteLine($"Conta criada para {this.titular}");
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
            Console.WriteLine($"Depositando R$ {valor}");
        }

        public void Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para efetuar o saque.");
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine($"Sacando R$ {valor}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R${this.saldo}");
        }




    }
}