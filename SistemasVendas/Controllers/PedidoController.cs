using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemasVendas.DTO;
using SistemasVendas.Models;
using SistemasVendas.Repository;

namespace SistemasVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly PedidosRepository _repository;
            public PedidoController(PedidosRepository repository)
            {
                _repository = repository;
            }

            [HttpPost]
            public IActionResult Cadastrar(CadastrarPedidoDTO dto)
            {
                var pedido = new Pedidos(dto);
                _repository.Cadastrar(pedido);
                return Ok(pedido);
            }

            [HttpGet("{id}")]
            public IActionResult ObterPorId(int id)
            {
                var pedido = _repository.ObterPorId(id);
                if(pedido is not null)
                {
                    return Ok(pedido);
                }
                else
                {
                    return NotFound(new {Mensagem = "Pedido não encontrado"});
                }
            }
    }
}