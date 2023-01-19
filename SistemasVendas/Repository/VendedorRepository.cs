using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasVendas.Context;
using SistemasVendas.DTO;
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
            _context.SaveChanges(); //Salvando as alterações
        }

        public Vendedor ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            return vendedor;
        }
        
        //Como pode retornar mais de um, está utilizando a lista
        public List<ObterVendedorDTO> ObterPorNome(string nome)
        {
            var vendedores = _context.Vendedores.Where(x => x.Nome.Contains(nome))
                                               //Criando uma nova classe ObterVendedorDTO
                                                .Select(x => new ObterVendedorDTO(x))
                                               //Transformando em uma lista
                                                .ToList();
            return vendedores;
        }

        //atualizar
        public Vendedor AtualizarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();

            return vendedor;
        }

        //deletar
        public void DeletarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }

        public void AtualizarSenha(Vendedor vendedor, AtualizarSenhaVendedorDTO dto)
        {
            vendedor.Senha = dto.Senha;
            AtualizarVendedor(vendedor);
        }
    }
}