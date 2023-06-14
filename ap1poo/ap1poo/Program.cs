using System;

namespace ap1poo
{
    class Program
    {
        static List<Produto> listaProduto = new List<Produto>();
        static List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        static List<Compra> listaCompra = new List<Compra>();
        private static int id;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Cadastrar fornecedor");
                Console.WriteLine("3 - Realizar compra");
                Console.WriteLine("4 - Listar produtos");
                Console.WriteLine("5 - Listar fornecedores");
                Console.WriteLine("6 - Listar compras");
                Console.WriteLine("0 - Sair");

                int v = int.Parse(Console.ReadLine());
                int opcao = v;

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
          /*          case 2:
                        CadastrarFornecedor();
                        break;
                    case 3:
                        RealizarCompra();
                        break;
                    case 4:
                        ListarProduto();
                        break;
                    case 5:
                        ListarFornecedores();
                        break;
                    case 6:
                        ListarCompras();
                        break; */
                    case 0:
                        System.Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        break;

                }
            }
        }
    }
}