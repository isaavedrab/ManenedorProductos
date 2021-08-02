using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantenedorProductos.WIN.VModels
{
    public class ProductoVM : Producto
    {
        public string Categoria { get; set; }
        public string Marca { get; set; }
    }
}
