using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    public class ServicoPedido
    {
        private readonly RepositorioPedido _repositorio;
        private readonly ILog _logger;
        private readonly List<IDescStrategy> _estrategias;

        public ServicoPedido(RepositorioPedido repositorio, ILog logger, List<IDescStrategy> estrategias)
        {
            _repositorio = repositorio;
            _logger = logger;
            _estrategias = estrategias;
        }

        public void ProcessarPedido(Pedido pedido)
        {
            pedido.CalcularTotal(_estrategias);
            _repositorio.Salvar(pedido);
            _logger.Log($"Pedido {pedido.Id} processado para cliente {pedido.Cliente.Nome}. Total: R${pedido.Total:F2}");
        }
    }


}
