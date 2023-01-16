using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasVendas.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int VendedorId { get; set; } //chave estrangeira
        public Vendedor Vendedor { get; set; } //referencia de classe da chave estrangeira
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}