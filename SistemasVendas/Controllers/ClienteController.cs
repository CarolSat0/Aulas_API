using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemasVendas.Repository;
using SistemasVendas.DTO;
using SistemasVendas.Models;

namespace SistemasVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
       private readonly ClienteRepository _repository;
       public ClienteController(ClienteRepository repository)
       {
            _repository = repository;
       }

        [HttpPost]
       public IActionResult Cadastrar(CadastrarClienteDTO dto)
       {
            var cliente = new Cliente(dto);
            _repository.Cadastrar(cliente);
            return Ok();
       }
    }
}