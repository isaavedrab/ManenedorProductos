using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MantenedorProductos.LIB.Servicios
{
    public class ServicioCategoria
    {
        private readonly DataBase _DataBase;

        public ServicioCategoria(DataBase dataBase) {
            
            _DataBase = dataBase;            
        }

        #region CRUD        
        public Guid Crear(Categoria categoria) {

            var guid = Guid.NewGuid();
            if (_DataBase.Categorias.Any(c => c.Nombre.ToLower().Equals(categoria.Nombre.ToLower())))
            {
                throw new Exception("La Categoría ya existe.");
            }
            else {             
                _DataBase.Categorias.Add(new Categoria() { 
                    Id = guid, 
                    Nombre = categoria.Nombre,
                    IdSubCategoria = categoria.IdSubCategoria
                });                
            }
            return guid;
        }
        public Categoria Obtener(Guid idCategoria)
        {
            if (!_DataBase.Categorias.Any(c => c.Id.Equals(idCategoria)))
            {
                throw new Exception("No se encontró Categoría.");
            }
            else 
            {
                return _DataBase.Categorias.First(c => c.Id.Equals(idCategoria));
            }            
        }
        public bool Actualizar(Guid idCategoria, Categoria categoria)
        {            
            if (!_DataBase.Categorias.Any(c => c.Id.Equals(idCategoria)))
            {
                throw new Exception("No se encontró la Categoría.");
            }
            else 
            {
                _DataBase.Categorias.Where(c => c.Nombre.ToLower().Equals(categoria.Nombre.ToLower()))
                   .Select(c =>
                   {
                       if (!c.Id.Equals(idCategoria))
                       {
                           throw new Exception("El nombre de la Categoría ya se encuentra registrado.");
                       }
                       return c;
                   });

                _DataBase.Categorias.Where(c => c.Id.Equals(idCategoria))
                    .Select(c =>
                    {
                        c.Nombre = categoria.Nombre;
                        c.IdSubCategoria = categoria.IdSubCategoria;
                        return c;
                    }).ToList();

                return true;                
            }            
        }
        public bool Eliminar(Guid idCategoria) 
        {
            if (!_DataBase.Categorias.Any(p => p.Id.Equals(idCategoria)))
            {
                throw new Exception("No se encontró Categoría.");
            }
            else 
            {
                if (_DataBase.Productos.Any(p => p.IdCategoria.Equals(idCategoria)))
                {
                    throw new Exception("No es posible eliminar la Categoría ya que esta siendo utilizada en un producto.");
                }
                else
                {
                    var item = _DataBase.Categorias.First(c => c.Id.Equals(idCategoria));
                    _DataBase.Categorias.Remove(item);
                    return true;
                }
            }                                      
        }
        public List<Categoria> Buscar()
        {
            if (_DataBase.Categorias.Count().Equals(0)) 
            {
                throw new Exception("No se han encontrado resultados.");            
            }
            else 
            {
                return _DataBase.Categorias;
            }            
        }
        #endregion
    }
}
