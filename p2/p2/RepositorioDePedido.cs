using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
  public class RepositorioPedido
  {
    private readonly List<Pedido> _pedidos = new();

    public void Salvar(Pedido pedido)
    {
      _pedidos.Add(pedido);
    }

    public List<Pedido> ListarTodos()
    {
      return _pedidos;
    }
  }
}
