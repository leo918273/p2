using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
  public class FabricaDePedido
  {
    public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens)
    {
      return new Pedido(id, cliente, itens, DateTime.Now);
    }
      
  }
}
