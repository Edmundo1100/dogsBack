using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogs.API.Model;
using dogs.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dogs.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioRepository _repository { get; }
        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var listaUsuarios = _repository.Get();
            return Ok(listaUsuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _repository.Get(id);
            if (usuario == null)
            {
                return NotFound("Não encontrado");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Usuario usuario)
        {
            _repository.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        // [HttpPut]
        public IActionResult Update([FromBody] Usuario usuario, int id)
        {
            _repository.Updade(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }

    }
}