using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemasVendas.Models;

namespace SistemasVendas.Context
{
    public class VendasContext : DbContext
    {
        //Construtor especial que recebe as configurações do banco de dados
        public VendasContext(DbContextOptions<VendasContext> options) : base(options) // base = mandando algo para a classe mãe
        {
            
        }
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<ItemPedido> ItemPedidos {get; set;}
        public DbSet<Pedidos> Pedidos {get; set;}
        public DbSet<Servico> Servicos {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}
    }
}