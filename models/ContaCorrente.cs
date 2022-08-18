using exercicio_orientacao_a_objetos.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_orientacao_a_objetos.models
{
    internal class ContaCorrente : Conta
    {    
        
        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }
        public ContaCorrente(int agencia, int numero, decimal saldo, DateTime dataAbertura, IList<Cliente> clientes, TipoConta tipo) : base(agencia, numero, saldo, dataAbertura, clientes)
        {
            Tipo = tipo;
            if (Tipo == TipoConta.Premium)
                Limite = 1000;
            else if (Tipo == TipoConta.Especial)
                Limite = 500;
            
        }

    


     

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (valor > Saldo + Limite)
            {
                throw new SaldoInsuficienteException($"Valor disponivel: {Saldo + Limite }");
            }
            Saldo -= valor;
          
        }


        public enum TipoConta
         {
        Comum, Especial, Premium
         }   
    }

    
}
