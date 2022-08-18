// See https://aka.ms/new-console-template for more information
using exercicio_orientacao_a_objetos.models;

Console.WriteLine("Digite a quantidade de clientes: ");
var qtdClientes = Convert.ToInt32(Console.ReadLine());
// Ler a quantidade de clientes
List<Cliente> listaClientes = new List<Cliente>();
for (int i = 0; i < qtdClientes; i++)

{
    Console.WriteLine("Nome do cliente: ");
    var nomeCliente = Console.ReadLine();
    Console.WriteLine("CPF do cliente: ");
    var cpfCliente = Console.ReadLine();
    Cliente cliente = new Cliente(i, nomeCliente, cpfCliente);
    listaClientes.Add(cliente);
}

Console.WriteLine( listaClientes);

// Criar uma lista de clientes 

// Ler os dados da conta corrente

Console.WriteLine("ABRIR UMA CONTA CORRENTE ");
Console.WriteLine("Numero agencia: ");
var nmAgencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Numero: ");
var numero = Convert.ToInt32(Console.ReadLine());


// Instanciar a conta corrente.
ContaCorrente contaCorrente = new ContaCorrente(nmAgencia, numero, 0m, DateTime.Now, listaClientes, ContaCorrente.TipoConta.Comum);



// Exibir os dados da conta corrente
Console.WriteLine(contaCorrente);
// Implementar um menu para 1-Depositar, 2-Retirar, 3-Exibir Dados, 0-Sair
