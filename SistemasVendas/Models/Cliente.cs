using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasVendas.DTO;

namespace SistemasVendas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Cliente()
        {

        }

        public Cliente(CadastrarClienteDTO dto)
        {
            Nome = dto.Nome;
            Login = dto.Login;
            Senha = dto.Senha;
        }
    }
}