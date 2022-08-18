using exercicio_orientacao_a_objetos.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_orientacao_a_objetos.models
{
    internal class ContaPoupanca : Conta, IcontaInvestimento
    {
        public ContaPoupanca(int agencia, int numero, decimal saldo, DateTime dataAbertura, IList<Cliente> clientes, decimal taxa) : base(agencia, numero, saldo, dataAbertura, clientes)
        {
            Taxa = taxa;
        }
        public decimal Taxa { get; set; }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * 0.04m; // m -> Transforma o double em decimal
        }

    
        public override void Retirar(decimal valor)
        {
            if(valor > Saldo - Taxa)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor + Taxa;
        }
    }
}
