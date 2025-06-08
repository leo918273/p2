using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
  internal class DescQuantidade : IDescStrategy
  {
    public decimal Calcular(ItemPedido item)
    {
      if (item.Quantidade >= 5)
      return item.CalcularValorTotal() *0.2m;
      return 0;
    }
  }
  
}
