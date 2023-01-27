using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasVendas.Context;
using SistemasVendas.Models;

namespace SistemasVendas.Repository
{
    public class ClienteRepository
    {
        private readonly VendasContext _context;

        public ClienteRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}