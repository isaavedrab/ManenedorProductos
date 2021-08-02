using MantenedorProductos.LIB.Modelos;
using MantenedorProductos.LIB.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MantenedorProductos.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ServicioCategoria _servicioCategoria;
        public CategoriasController(ServicioCategoria servicioCategoria) {
            _servicioCategoria = servicioCategoria;
        }              
      
        // GET: api/<CategoriasController>
        [HttpGet]
        public IActionResult Get() 
        {     
            try 
            {
                var categorias = _servicioCategoria.Buscar();
                return Ok(categorias);
            }
            catch(Exception e){ return BadRequest(e.Message); }
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    var categoria = _servicioCategoria.Obtener(id);
                    return Ok(categoria);
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else {
                return BadRequest(new Exception("El identificador no es válido."));
            }
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                var id =_servicioCategoria.Crear(categoria);
                return Ok( new { Id = id }) ;
            }
            catch (Exception e) { return BadRequest(e.Message); }            
        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Categoria value)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioCategoria.Actualizar(id, value);
                    return Ok();
                }
                catch (Exception e){ return BadRequest(e.Message);}
            }
            else {
                return BadRequest(new Exception("El identificador no es válido."));
            }            
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {           
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioCategoria.Eliminar(id);
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
