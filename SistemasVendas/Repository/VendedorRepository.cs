using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasVendas.Context;
using SistemasVendas.Models;

namespace SistemasVendas.Repository
{
    public class VendedorRepository
    {
        private readonly VendasContext _context; //atributo VendasContext que recebe o nome "_context"
        public VendedorRepository(VendasContext context){
            _context = context;
        }

        public void Cadastrar(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }
    }
}