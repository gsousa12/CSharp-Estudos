﻿

using System.Globalization;

namespace Conta_Bancaria
{
    internal class ContaBancaria
    {

        private int descontoDeSaque = 5;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + descontoDeSaque;
        }
        public override string ToString()
        {
            return "Conta" 
                + Numero 
                + ", Titular: " 
                +  Titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
