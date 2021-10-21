using System;
using System.Globalization;
using System.Collections.Generic;


namespace Herança
{
    class Program
    {


        static void Main(string[] args)
        {
            //Criando a lista de strings
            List<Conta> list = new List<Conta>();
            //Adicionando elementos na Lista
            list.Add(new ContaPoupanca(1001, "Daniel", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "jon", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Billy", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Ana", 500.0, 400.0));

            double soma = 0.0;
            foreach (Conta A1 in list)
            {
                soma += A1.Saldo;
            }

            // esta mostrando o saldo total das contas
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Conta A1 in list)
            {
                A1.Saque(10.0);
            }

            //atualização do saldo das contas
            foreach (Conta A1 in list)
            {
                Console.WriteLine("Atualização do saldo das contas "
                +A1.Numero + ": " + A1.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }   
}

        