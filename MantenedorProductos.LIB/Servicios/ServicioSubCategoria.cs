using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MantenedorProductos.LIB.Servicios
{
    public class ServicioSubCategoria
    {
        private readonly DataBase _DataBase;
        public ServicioSubCategoria(DataBase dataBase)
        {
            _DataBase = dataBase;
        }

        #region CRUD   
        public Guid Crear(SubCategoria subCategoria)
        {
            var guid = Guid.NewGuid();
            if (_DataBase.SubCategorias.Any(c => c.Nombre.ToLower().Equals(subCategoria.Nombre.ToLower())))
            {
                throw new Exception("La Sub Categoría ya existe.");
            }
            else
            {
                _DataBase.SubCategorias.Add(new SubCategoria()
                {
                    Id = guid,
                    Nombre = subCategoria.Nombre
                });
            }
            return guid;
        }
        public SubCategoria Obtener(Guid idSubCategoria)
        {
            if (!_DataBase.SubCategorias.Any(c => c.Id.Equals(idSubCategoria)))
            {
                throw new Exception("No se encontró Sub Categoría.");
            }
            else
            {
                return _DataBase.SubCategorias.First(c => c.Id.Equals(idSubCategoria));
            }
        }
        public bool Actualizar(Guid idSubCategoria, SubCategoria subCategoria)
        {
            if (!_DataBase.SubCategorias.Any(c => c.Id.Equals(idSubCategoria)))
            {
                throw new Exception("No se encontró la Sub Categoría.");
            }
            else
            {
                _DataBase.SubCategorias.Where(c => c.Nombre.ToLower().Equals(subCategoria.Nombre.ToLower()))
                    .Select(c =>
                    {
                        if (!c.Id.Equals(idSubCategoria))
                        {
                            throw new Exception("El nombre de la Sub Categoría ya se encuentra registrado.");
                        }
                        return c;
                    });

                _DataBase.SubCategorias.Where(c => c.Id.Equals(idSubCategoria))
                    .Select(c =>
                    {
                        c.Nombre = subCategoria.Nombre;
                        return c;
                    }).ToList();

                return true;             
            }
        }
        public bool Eliminar(Guid idSubCategoria)
        {
            if (!_DataBase.SubCategorias.Any(c => c.Id.Equals(idSubCategoria)))
            {
                throw new Exception("No se encontró Sub Categoría.");
            }
            else
            {
                if (_DataBase.Categorias.Any(c => c.IdSubCategoria.Equals(idSubCategoria)))
                {
                    throw new Exception("No es posible eliminar la Sub Categoría ya que esta siendo utilizada en una Categoría.");
                }
                else
                {
                    var item = _DataBase.SubCategorias.First(c => c.Id.Equals(idSubCategoria));
                    _DataBase.SubCategorias.Remove(item);
                    return true;
                }
            }
        }
        public List<SubCategoria> Buscar()
        {
            if (_DataBase.SubCategorias.Count().Equals(0))
            {
                throw new Exception("No se han encontrado resultados.");
            }
            else
            {
                return _DataBase.SubCategorias;
            }
        }
        #endregion
    }
}
