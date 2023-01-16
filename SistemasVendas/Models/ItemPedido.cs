using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasVendas.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedidos Pedido { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}