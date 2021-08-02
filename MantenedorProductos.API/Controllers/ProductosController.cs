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
    public class ProductosController : ControllerBase
    {
        private readonly ServicioProducto _servicioProducto;
        private readonly ServicioCategoria _servicioCategoria;
        private readonly ServicioMarca _servicioMarca;
        public ProductosController(ServicioProducto servicioProducto, ServicioCategoria servicioCategoria, ServicioMarca servicioMarca)
        {
            _servicioProducto = servicioProducto;
            _servicioCategoria = servicioCategoria;
            _servicioMarca = servicioMarca;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var productos = _servicioProducto.Buscar();
                var categorias = _servicioCategoria.Buscar();
                var marcas = _servicioMarca.Buscar();
                var data = (from p in productos
                            join c in categorias.DefaultIfEmpty() on p.IdCategoria equals c.Id
                            join m in marcas.DefaultIfEmpty() on p.IdMarca equals m.Id
                            select new
                            {
                                p.Id,
                                p.Nombre,
                                p.CodBarra,
                                p.Precio,
                                p.IdCategoria,
                                p.IdMarca,
                                Categoria = c.Nombre,
                                Marca = m.Nombre
                            }).ToList();

                return Ok(data);
            }
            catch (Exception e) { return BadRequest(e.Message); }            
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    var producto = _servicioProducto.Obtener(id);
                    return Ok(producto);
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }            
        }

        // POST api/<ProductoController>
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            try
            {
                var id = _servicioProducto.Crear(producto);
                return Ok(new { Id = id });
            }
            catch (Exception e) { return BadRequest(e.Message); }         
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Producto value)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioProducto.Actualizar(id, value);
                    return Ok();
                }
                catch (Exception e) { return BadRequest(e.Message); }
            }
            else
            {
                return BadRequest(new Exception("El identificador no es válido."));
            }            
        }
    
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id != null && (id != Guid.Empty))
            {
                try
                {
                    _servicioProducto.Eliminar(id);
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
