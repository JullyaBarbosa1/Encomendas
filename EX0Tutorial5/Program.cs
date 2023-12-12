using EX0Tutorial5.Entities;
using EX0Tutorial5.Entities.Enums;
using System.Collections.Generic;

namespace EX0Tutorial5
{
    internal class Program
    {

        static public List<Client> listaClientes = new List<Client>();
        static public List<Product> listaProdutos = new List<Product>();
        static public List<Order> listaEncomendas = new List<Order>();

        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("===============MENU==============");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Apresentar CLientes");
                Console.WriteLine("3. Adicionar Produtos");
                Console.WriteLine("4. Apresentar Produtos");
                Console.WriteLine("5. Adicionar Encomenda");
                Console.WriteLine("6. Apresentar Encomendas");
                Console.WriteLine("7. Sair");

                Console.Write("\n\t\t Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {

                    case "1":
                        InserirCliente();
                        break;
                    case "2":
                        ApresentarCliente();
                        break;
                    case "3":
                        AdicionarProduto();
                        break;
                    case "4":
                        ApresentarProdutos();
                        break;
                    case "5":
                        InserirEncomendas();
                        break;
                    case "6":
                        ApresentarEncomendas();
                        break;
                    case "7":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        static public void InserirCliente()
        {
            Console.WriteLine("Dados do cliente:");
            Console.Write("Nome:");
            string nomCliente = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento:");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dn))
            {
                Client cl = new Client(nomCliente, email, dn);
                listaClientes.Add(cl);
                Console.WriteLine($"Cliente{cl.ToString()}" +
                    $"adicionado com sucesso! ");
            }
        }
        static public void ApresentarCliente()
        {
            Console.WriteLine("\n\nLista de clientes inseridos no sistema: ");
            foreach (Client client in listaClientes)
                Console.WriteLine(client.ToString());
        }
        static public void AdicionarProduto()
        {
            Console.WriteLine("\nInserir dados do novo produto: ");
            Console.Write("Nome:");
            string nomProduto = Console.ReadLine();
            Console.Write("Preço (PVP): ");
            double pvp = double.Parse(Console.ReadLine());
            Product p= new Product(nomProduto, pvp);
            listaProdutos.Add(p);
            Console.WriteLine($"\n Produto {p.ToString()}inserido" +
                $"com sucesso!");
        }
        static public void ApresentarProdutos()
        {

            Console.WriteLine("\n\nLista de produtos inseridos no sistema: ");
            foreach (Product pd in listaProdutos)
                Console.WriteLine(pd.ToString());
        }
        static public void InserirEncomendas()
        {
            Console.Write("Estado da Encomenda (0 - Pendente, 1 - Processando," +
                "2 - Em envio, 3 - Entregue): ");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), 
                Console.ReadLine());
            DateTime dt = DateTime.Now;
            Console.WriteLine("Selecione o cliente prorpietário da encomenda: ");
            for (int i = 0; i < listaClientes.Count; i++)
                Console.WriteLine($"{i} - {listaClientes[i].Name}");
            Console.Write("Indice do cliente: ");

            int id = int.Parse(Console.ReadLine());
            if (id > 0 && id < listaClientes.Count)
            {
                Order order = new Order(dt, os, listaClientes[id]);
                listaEncomendas.Add(order);
                bool inserirItems = true;
                while (inserirItems)

                {
                    Console.Write("Produtos no sistema:");
                    for (int i = 0; i < listaProdutos.Count; i++)
                        Console.WriteLine($"{i} - {listaProdutos[i].Name}");
                    Console.Write("Indice do produto: ");
                    id = int.Parse(Console.ReadLine());
                    if (id > 0 && id < listaProdutos.Count)
                    {
                        Product p = listaProdutos[id];
                        Console.Write("Quantidade: ");
                        int qt = int.Parse(Console.ReadLine());
                        Console.Write("Preço: ");
                        double px = double.Parse(Console.ReadLine());
                        order.AddItem(new OrderItem(p, qt, px));
                    }
                    else
                        Console.WriteLine("Indice de produto inválido!");
                    Console.Write("Inserir novo item á encomenda? s/n:");
                    if (Console.ReadLine().ToUpper() != "S")
                        inserirItems = false;
                }
            }
            else
                Console.WriteLine("Indice de cliente inválido!");

        }
        static public void ApresentarEncomendas()
        {

            Console.WriteLine("Lista de encomendas inseridas no sistema: ");
            foreach (Order or in listaEncomendas)
                Console.WriteLine(or.ToString());   


        }
    }
}

