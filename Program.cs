using p2;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var produto1 = new Produto(1, "notebook", 3000m, "Eletrônicos");
        var produto2 = new Produto(2, "Caderno", 20m, "Papelaria");

        var cliente = new Cliente(1, "João", "Joao@gmail.com", "123.456.789-00");

        var itensPedido = new List<ItemPedido>
        {
            new ItemPedido(produto1, 1),
            new ItemPedido(produto2, 3)
        };

        var fabricaPedido = new FabricaDePedido();
        var pedido = fabricaPedido.CriarPedido(1, cliente, itensPedido);

        var repositorioPedido = new RepositorioPedido();
        var logger = new ConsoleLog();
        var estrategiaDesconto = new List<IDescStrategy> { new DescCategoria(), new DescQuantidade() };

        var servicoPedido = new ServicoPedido(repositorioPedido, logger, estrategiaDesconto);
        servicoPedido.ProcessarPedido(pedido);

        foreach (var p in repositorioPedido.ListarTodos())
        {
            Console.WriteLine($"Pedido {p.Id} - Cliente: {p.Cliente.Nome} - Total: R${p.Total:F2}");
        }
    }
}
