using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasVendas.Models;

namespace SistemasVendas.DTO
{
    public class ObterVendedorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }

        public ObterVendedorDTO(Vendedor vendeor)
        {
            Id = vendeor.Id;
            Nome = vendeor.Nome;
            Login = vendeor.Login;
        }
    }
}