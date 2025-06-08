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
      
  }
}
