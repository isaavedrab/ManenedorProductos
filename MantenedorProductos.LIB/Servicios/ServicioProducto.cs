using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MantenedorProductos.LIB.Servicios
{
    public class ServicioProducto
    {
        private readonly DataBase _DataBase;
        public ServicioProducto(DataBase dataBase)
        {
            _DataBase = dataBase;            
        }

        #region CRUD
        public Guid Crear(Producto producto) 
        {
            var guid = Guid.NewGuid();
            if (_DataBase.Productos.Any(c => c.Nombre.ToLower().Equals(producto.Nombre.ToLower())))
            {
                throw new Exception("El Producto ya existe.");
            }
            else if (_DataBase.Productos.Any(c => c.CodBarra.ToLower().Equals(producto.CodBarra.ToLower())))
            {
                throw new Exception("El Código de Barra ya existe.");
            }
            else
            {
                _DataBase.Productos.Add(new Producto() 
                { 
                    Id = guid, 
                    Nombre = producto.Nombre,
                    CodBarra = producto.CodBarra,
                    Precio = producto.Precio,
                    IdCategoria = producto.IdCategoria,
                    IdMarca = producto.IdMarca,
                });
            }
            return guid;                        
        }
        public Producto Obtener(Guid idProducto) 
        {
            if (!_DataBase.Productos.Any(p => p.Id.Equals(idProducto)))
            {
                throw new Exception("No se encontró Producto.");
            }
            else
            {
                return _DataBase.Productos.First(p => p.Id.Equals(idProducto));
            }            
        }
        public bool Actualizar(Guid idProducto, Producto producto) 
        {
            if (!_DataBase.Productos.Any(p => p.Id.Equals(idProducto)))
            {
                throw new Exception("No se encontró Producto.");
            }
            else
            {
                _DataBase.Productos.Where(c => c.Nombre.ToLower().Equals(producto.Nombre.ToLower()))
                   .Select(c =>
                   {
                       if (!c.Id.Equals(idProducto))
                       {
                           throw new Exception("El nombre del Producto ya se encuentra en uso.");
                       }
                       return c;
                   });

                _DataBase.Productos.Where(p => p.Id.Equals(idProducto))
                    .Select(p =>
                    {
                        p.Nombre = producto.Nombre;
                        p.CodBarra = producto.CodBarra;
                        p.Precio = producto.Precio;
                        p.IdCategoria = producto.IdCategoria;
                        p.IdMarca = producto.IdMarca;
                        return p;
                    }).ToList();

                return true;                
            }         
        }
        public bool Eliminar(Guid idProducto)
        {
            if (!_DataBase.Productos.Any(p => p.Id.Equals(idProducto)))
            {
                throw new Exception("No se encontró Producto.");
            }
            else 
            {
                var item = _DataBase.Productos.First(p => p.Id.Equals(idProducto));
                _DataBase.Productos.Remove(item);
                return true;
            }            
        }
        public List<Producto> Buscar()
        {
            if (_DataBase.Productos.Count().Equals(0))
            {
                throw new Exception("No se han encontrado resultados.");
            }
            else
            {
                return _DataBase.Productos;                                 
            }            
        }              
        #endregion
    }
}
