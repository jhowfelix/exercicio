using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_orientacao_a_objetos.models
{
    public class Cliente
    {
        public long Id { get; set; }
        public String nome { get; set; }
        public String cpf { get; set; }

        public Cliente(long id, string nome, string cpf)
        {
            Id = id;
            this.nome = nome;
            this.cpf = cpf;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }



    
}
