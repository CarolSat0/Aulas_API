using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasVendas.DTO //Data Transfer Object
{
    public class CadastrarVendedorDTO
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}