using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_orientacao_a_objetos.models
{
    internal abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public Decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public Conta(int agencia, int numero, decimal saldo, DateTime dataAbertura, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            DataAbertura = dataAbertura;
            Clientes = clientes;
        }

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public abstract void Retirar(decimal valor);
    }
}
