using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class ContaPoupanca : Conta
    {
        //Declarações das variáveis
        public double TaxaJuros{ get; set; }
        //Criação do construtor padrão
        public ContaPoupanca() { }
        //Criação do construtor com parâmetros 
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) 
            : base(numero, titular, saldo)
        { 
            TaxaJuros = taxaJuros; 
        }
        // Método de atualizacao de Saldo
        public void atualizacaoSaldo() { 
            Saldo += Saldo * TaxaJuros;
        }
        //Método  de Saldo Total
        public override void Saque(double saldoTotal) {
            base.Saque(saldoTotal); 
            Saldo -= 2.0; 
        }
    }
}

