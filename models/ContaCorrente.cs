using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_orientacao_a_objetos.models
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero, decimal saldo, DateTime dataAbertura, IList<Cliente> clientes) : base(agencia, numero, saldo, dataAbertura, clientes)
        {
        }

        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }


     

        public override void Depositar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
        public enum TipoConta
    {
        Comum, Especial, Premium
    }
    }

    
}
