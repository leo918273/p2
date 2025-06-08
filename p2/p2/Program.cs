
using p2;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var produto1 = new Produto(1, "Notebook", 3000m, "Eletrônicos");
        var produto2 = new Produto(2, "Caderno", 20m, "Papelaria");

        var cliente = new Cliente(1, "João Silva", "joao@email.com", "123.456.789-00");

        var itensPedido = new List<ItemPedido>
        {
            new ItemPedido(produto1, 1),
            new ItemPedido(produto2, 6)
        };

        var fabricaPedido = new FabricaDePedido();
        var pedido = fabricaPedido.CriarPedido(1, cliente, itensPedido);

        var repositorioPedido = new RepositorioPedido();
        var logger = new ConsoleLog();
        var estrategiasDesconto = new List<IDescStrategy> { new DescCategoria(), new DescontoPorQuantidade() };

        var servicoPedido = new ServicoPedido(repositorioPedido, logger, estrategiasDesconto);
        servicoPedido.ProcessarPedido(pedido);

        foreach (var p in repositorioPedido.ListarTodos())
        {
            Console.WriteLine($"Pedido {p.Id} - Cliente: {p.Cliente.Nome} - Total: R${p.Total:F2}");
        }
    }
}
