using ApiVeiculos.Application.Commands.Adicionar;
using ApiVeiculos.Application.Commands.Atualizar;
using ApiVeiculos.Application.Commands.Excluir;
using ApiVeiculos.Application.Commands.Listar;
using ApiVeiculos.Application.Commands.ObterPorId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiVeiculos.WebApi.Controllers
{
    [ApiController]
    [Route("api/veiculos")]
    public class VeiculosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VeiculosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var veiculos = await _mediator.Send(new ListarVeiculosCommand());
            return Ok(veiculos);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var veiculo = await _mediator.Send(new ObterVeiculoPorIdCommand(id));


            if (veiculo is null)
                return NotFound();


            return Ok(veiculo);
        }
        
        [HttpPost]
        public async Task<IActionResult> Adicionar(AdicionarVeiculoCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(Adicionar), new { id }, null);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] AtualizarVeiculoCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(Guid id)
        {
            await _mediator.Send(new ExcluirVeiculoCommand(id));
            return NoContent();
        }
    }
}
