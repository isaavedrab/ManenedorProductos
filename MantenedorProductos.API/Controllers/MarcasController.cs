using MantenedorProductos.LIB.Modelos;
using MantenedorProductos.LIB.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MantenedorProductos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly ServicioMarca _servicioMarca;
        public MarcasController(ServicioMarca servicioMarca)
        {
            _servicioMarca = servicioMarca;
        }

        // GET: api/<MarcasController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var marcas = _servicioMarca.Buscar();
                return Ok(marcas);
            }
            catch (Exception e) { return BadRequest(e.Message); }            
        }

        // GET api/<MarcasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    var marca = _servicioMarca.Obtener(id);
                    return Ok(marca);
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }
        }

        // POST api/<MarcasController>
        [HttpPost]
        public IActionResult Post([FromBody] Marca marca)
        {
            try
            {
                var id = _servicioMarca.Crear(marca);
                return Ok(new { Id = id });
            }
            catch (Exception e) { return BadRequest(e.Message); }
        }

        // PUT api/<MarcasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Marca marca)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioMarca.Actualizar(id, marca);
                    return Ok();
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));

            }
        }

        // DELETE api/<MarcasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioMarca.Eliminar(id);
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
