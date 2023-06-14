using Levva.Newbies.Intensivo.Logic.Dtos;
using Levva.Newbies.Intensivo.Logic.Interfaces;
using Levva.Newbies.Intensivo.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Intensivo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _service;
        public TransacaoController(TransacaoService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public IActionResult Create(TransacaoDto transacao)
        {
            _service.Create(transacao);
            return Created("", transacao);
        }
        [HttpGet]
        public ActionResult<TransacaoDto> Get(int id)
        {
            return _service.Get(id);
        }
        [HttpGet("list")]
        public ActionResult<List<TransacaoDto>> GetAll(int id)
        {
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(TransacaoDto transacao)
        {
            _service.Update(transacao);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
