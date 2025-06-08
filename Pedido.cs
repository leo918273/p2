.﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2pratico
{
public int Id { get; }
public Cliente Cliente { get; }
public List<ItemPedido> Itens { get; }
public DateTime Data { get; }
public decimal Total { get; private set; }

public Pedido(int id, Cliente cliente, List<ItemPedido> itens, DateTime data)
{
    Id = id;
    Cliente = cliente;
    Itens = itens;
    Data = data;
}

}
