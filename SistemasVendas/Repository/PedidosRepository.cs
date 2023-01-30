using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemasVendas.Context;
using SistemasVendas.Models;

namespace SistemasVendas.Repository
{
    public class PedidosRepository
    {
        private readonly VendasContext _context;
        public PedidosRepository(VendasContext context)
        {
            _context = context;
        }

        public Pedidos Cadastrar(Pedidos pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return pedido;
        }

        public Pedidos ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Include(x => x.Vendedor)
                                         .Include(x => x.Cliente)
                                         .FirstOrDefault(x => x.Id == id);
            return pedido;
        }
    }
}