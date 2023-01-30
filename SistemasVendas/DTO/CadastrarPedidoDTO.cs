using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasVendas.DTO
{
    public class CadastrarPedidoDTO
    {
        public DateTime Data { get; set; }
        public int VendedorId { get; set; } //chave estrangeira
        public int ClienteId { get; set; }
    }
}