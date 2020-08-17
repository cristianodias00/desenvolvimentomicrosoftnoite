using System;
using System.Linq.Expressions;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcao;
            Cliente c = new Cliente();
            List<Cliente> clientes = new List<Cliente>();

            do
            {
               //Console.Clear serve para limpar o laço de repetição
                Console.Clear();

                Console.WriteLine("\n+++MENU PRINCIPAL+++\n\n");

                Console.WriteLine("1 - Cadastrar Cliente\n");
                Console.WriteLine("2 - Listar Clientes\n");
                Console.WriteLine("3 - Cadastrar Vendedor\n");
                Console.WriteLine("4 - Listar Vendedores\n");
                Console.WriteLine("5 - Cadastrar Produtos\n");
                Console.WriteLine("6 - Listar Produtos\n");
                Console.WriteLine("7 - Registrar Vendas\n");
                Console.WriteLine("8 - Listar Vendas\n");
                Console.WriteLine("9 - Listar Vendas por Cliente\n");
                Console.WriteLine("0 - Sair\n\n");

                Console.WriteLine("Digite a Opção Desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("---- CADASTRAR CLIENTE ----\n");

                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        //Console.WriteLine($"Cliente: {c.Nome}");

                        Console.WriteLine("Digite o CPF do cliente:");
                        c.CPF = Console.ReadLine();

                        cliente.Add(c);

                        //Mostrar uma msg de sucesso do salvamento das informações
                        //Console.WriteLine($"Nome: {c.Nome} e CPF: {c.CPF}");
                        Console.WriteLine("Cliente salvo com sucesso!!!");

                        break;
                    case 2:
                        Console.WriteLine("---- LISTAR CLIENTES ----\n");
                        //Montar um laço de repetição para mostrar todos os clientes



                        break;
                    case 3:
                        Console.WriteLine("---- CADASTRAR VENDEDOR ----\n");
                        break;
                    case 4:
                        Console.WriteLine("---- LISTAR VENDEDORES ----\n");
                        break;
                    case 5:
                        Console.WriteLine("---- CADASTRAR PRODUTOS ----\n");
                        break;
                    case 6:
                        Console.WriteLine("---- LISTAR PRODUTOS ----\n");
                        break;
                    case 7:
                        Console.WriteLine("---- REGISTRAR VENDAS ----\n");
                        break;
                    case 8:
                        Console.WriteLine("---- LISTAR VENDAS ----\n");
                        break;
                    case 9:
                        Console.WriteLine("---- LISTAR VENDAS POR CLIENTE ----\n");
                        break;
                    case 0:
                        Console.WriteLine("---- SAINDO... ----\n");
                        break;
                    default:
                        Console.WriteLine("---- OPÇÃO INVÁLIDA ----\n");
                        break;
                }
                Console.WriteLine("\n Precione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}
