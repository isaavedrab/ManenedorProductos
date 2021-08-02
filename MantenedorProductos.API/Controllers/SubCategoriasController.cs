using MantenedorProductos.LIB.Modelos;
using MantenedorProductos.LIB.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MantenedorProductos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriasController : ControllerBase
    {
        private readonly ServicioSubCategoria _servicioSubCategoria;
        public SubCategoriasController(ServicioSubCategoria servicioSubCategoria)
        {
            _servicioSubCategoria = servicioSubCategoria;
        }

        // GET: api/<SubCategoriasController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var subCategorias = _servicioSubCategoria.Buscar();
                return Ok(subCategorias);
            }
            catch (Exception e) { return BadRequest(e.Message); }
        }

        // GET api/<SubCategoriasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    var subCategorias = _servicioSubCategoria.Obtener(id);
                    return Ok(subCategorias);
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }
        }

        // POST api/<SubCategoriasController>
        [HttpPost]
        public IActionResult Post([FromBody] SubCategoria subCategoria)
        {
            try
            {
                var id = _servicioSubCategoria.Crear(subCategoria);
                return Ok(new { Id = id });
            }
            catch (Exception e) { return BadRequest(e.Message); }
        }

        // PUT api/<SubCategoriasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] SubCategoria subCategoria)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioSubCategoria.Actualizar(id, subCategoria);
                    return Ok();
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }
        }

        // DELETE api/<SubCategoriasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioSubCategoria.Eliminar(id);
                    return Ok();
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }
        }
    }
}
