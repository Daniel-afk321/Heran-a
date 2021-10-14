using System;

namespace Herança
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            ContaJuridica Conta = new ContaJuridica(8010,"LaraCroft", 100.0, 500.0); 
            //esta mostrando o saldo
            Console.WriteLine(Conta.Saldo);
        }
    }
}
