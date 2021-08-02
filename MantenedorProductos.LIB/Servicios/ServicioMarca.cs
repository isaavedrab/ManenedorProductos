using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MantenedorProductos.LIB.Servicios
{
    public class ServicioMarca
    {
        private readonly DataBase _DataBase;
        public ServicioMarca(DataBase dataBase)
        {
            _DataBase = dataBase;
        }
        #region CRUD        
        public Guid Crear(Marca marca)
        {
            var guid = Guid.NewGuid();
            if (_DataBase.Marcas.Any(c => c.Nombre.ToLower().Equals(marca.Nombre.ToLower())))
            {
                throw new Exception("La Marca ya existe.");
            }
            else
            {
                _DataBase.Marcas.Add(new Marca()
                {
                    Id = guid,
                    Nombre = marca.Nombre
                });
            }
            return guid;
        }
        public Marca Obtener(Guid idMarca)
        {
            if (!_DataBase.Marcas.Any(c => c.Id.Equals(idMarca)))
            {
                throw new Exception("No se encontró Marca.");
            }
            else
            {
                return _DataBase.Marcas.First(c => c.Id.Equals(idMarca));
            }            
        }
        public bool Actualizar(Guid idMarca, Marca marca)
        {
            if (!_DataBase.Marcas.Any(c => c.Id.Equals(idMarca)))
            {
                throw new Exception("No se encontró la Marca.");
            }
            else
            {
                _DataBase.Marcas.Where(m => m.Nombre.ToLower().Equals(marca.Nombre.ToLower()))
                   .Select(m =>
                   {
                       if (!m.Id.Equals(idMarca))
                       {
                           throw new Exception("El nombre de la Marca ya se encuentra registrada.");
                       }
                       return m;
                   });

                _DataBase.Marcas.Where(m => m.Id.Equals(idMarca))
                    .Select(m =>
                    {
                        m.Nombre = marca.Nombre;
                        return m;
                    }).ToList();

                return true;                
            }
        }
        public bool Eliminar(Guid idMarca)
        {
            if (!_DataBase.Marcas.Any(p => p.Id.Equals(idMarca)))
            {
                throw new Exception("No se encontró Marca.");
            }
            else
            {
                if (_DataBase.Productos.Any(p => p.IdMarca.Equals(idMarca)))
                {
                    throw new Exception("No es posible eliminar la Marca ya que esta siendo utilizada en un producto.");
                }
                else
                {
                    var item = _DataBase.Marcas.First(c => c.Id.Equals(idMarca));
                    _DataBase.Marcas.Remove(item);
                    return true;
                }
            }
        }
        public List<Marca> Buscar()
        {
            if (_DataBase.Marcas.Count().Equals(0))
            {
                throw new Exception("No se han encontrado resultados.");
            }
            else
            {
                return _DataBase.Marcas;
            }
        }
        #endregion
    }
}
