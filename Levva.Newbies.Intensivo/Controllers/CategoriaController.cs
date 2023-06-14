using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;
using Levva.Newbies.Intensivo.Logic.Interfaces;
using Levva.Newbies.Intensivo.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Intensivo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;
        public CategoriaController(CategoriaService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public ActionResult<Categoria> Create(CategoriaDto categoria)
        {
            var categoriaCriada = _service.Create(categoria);
            return Ok(categoriaCriada);
        }
        [HttpGet]
        public ActionResult<CategoriaDto> Get(int id)
        {
            return _service.Get(id);
        }
        [HttpGet("list")]
        public ActionResult<List<CategoriaDto>> GetAll(int id)
        {
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(CategoriaDto categoria)
        {
            _service.Update(categoria);
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
