﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    abstract class Conta 
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string titular { get; private set; }
        //Utilização do protectedpara alteração de valores entre classes
        public double Saldo { get; protected set; }
        //Criação do construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string Titular, double saldo) {
            Numero = numero; Titular = titular; Saldo = saldo;
        }
        //Método de Saque
        public virtual void Saque(double saldoTotal) {
            Saldo -= saldoTotal + 5.0;
        }
        //Método de Deposito
        public void Deposito(double saldoTotal) { 
            Saldo += saldoTotal; 
        }



    }

    }
