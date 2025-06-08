using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
  public class DescCategoria : IDescStrategy
  {
    public decimal Calcular(ItemPedido item)
    {
      if (item.Produto.Categoria == "eletronico")
        return item.CalcularValorTotal() * 0.1m;
        return 0;
    }
  }
}
