using MantenedorProductos.LIB.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantenedorProductos.LIB
{
    public class DataBase
    {        
        public DataBase() 
        {      
           
        }

        private List<Producto> _productos = new List<Producto>()
            {
                new Producto(){
                    Id = Guid.Parse("21a16636-2226-41c8-a0d9-e272a962a6a3"),
                    Nombre = "Minicomponente BT / CJ45",
                    CodBarra = "A-0010-Z",
                    Precio = 129990,
                    IdCategoria = Guid.Parse("ed1a5272-5053-42a7-898a-4b63ba60bc9a"),
                    IdMarca = Guid.Parse("bfbce852-ccaa-4f4b-b93e-dd131edcab12")
                },
                 new Producto(){
                    Id = Guid.Parse("fe9987e9-0594-4e03-ad13-ea2bd2cbbccd"),
                    Nombre = "Galaxy S21",
                    CodBarra = "A-0020-Z",
                    Precio = 749990,
                    IdCategoria = Guid.Parse("22caf5a3-524d-4b9c-bfaf-af8785470e2d"),
                    IdMarca = Guid.Parse("5eff1f9d-6061-4ccf-b454-ec31fa296e49")
                },
                  new Producto(){
                    Id = Guid.Parse("8eeb07d9-7eea-422d-b721-f6991633abfb"),
                    Nombre = "LED SONY 55X90J SMART GOOGLE TV",
                    CodBarra = "A-0030-Z",
                    Precio = 959990,
                    IdCategoria = Guid.Parse("32e9f79c-07a6-40e1-b686-d52b9d165459"),
                    IdMarca = Guid.Parse("d6ac4586-a379-44ad-ad75-a4a238a6cfb5")
                },
                   new Producto(){
                    Id = Guid.Parse("c827ed0c-1ace-4740-bda6-dd3ac3fd41bd"),
                    Nombre = "AUDIFONOS NOISE CANCELLING QC35 SERIE II SILVER",
                    CodBarra = "A-0040-Z",
                    Precio = 309990,
                    IdCategoria = Guid.Parse("ed1a5272-5053-42a7-898a-4b63ba60bc9a"),
                    IdMarca = Guid.Parse("46da45c1-b131-4afb-98c5-28c280140b1e")
                },
            };
        public List<Producto> Productos
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new List<Producto>();                                         
                }
                return _productos;
            }
        }
        
        private List<Categoria> _categorias = new List<Categoria>(){
                new Categoria(){ Id = Guid.Parse("ed1a5272-5053-42a7-898a-4b63ba60bc9a"), Nombre = "Audio", IdSubCategoria = Guid.Parse("d5618086-cf61-46ea-8713-a6bb70964df2") },
                new Categoria(){ Id = Guid.Parse("32e9f79c-07a6-40e1-b686-d52b9d165459"), Nombre = "Televisión", IdSubCategoria = Guid.Parse("4d1ce933-969e-4ffb-98d1-b36aba122be3") },
                new Categoria(){ Id = Guid.Parse("f2da7d38-5805-4f49-a466-163dec5deae4"), Nombre = "Computación", IdSubCategoria = Guid.Parse("aec2e3b5-050f-42d4-a07d-ce2891e63080") },
                new Categoria(){ Id = Guid.Parse("22caf5a3-524d-4b9c-bfaf-af8785470e2d"), Nombre = "Celulares", IdSubCategoria = Guid.Parse("3a5f7f0f-5b31-452e-9da2-e2e23eb45864") },
            };
        public List<Categoria> Categorias
        {
            get 
            {
                if (_categorias == null) {
                    _categorias = new List<Categoria>();
                }
                return _categorias;
            }   
        }
        
        private List<Marca> _marcas = new List<Marca>()
            {
                new Marca(){ Id = Guid.Parse("bfbce852-ccaa-4f4b-b93e-dd131edcab12"), Nombre = "LG" },
                new Marca(){ Id = Guid.Parse("5eff1f9d-6061-4ccf-b454-ec31fa296e49"), Nombre = "Samsung" },
                new Marca(){ Id = Guid.Parse("ad6135d0-2dfd-42ab-ae60-aa4f2fd991a8"), Nombre = "HP" },
                new Marca(){ Id = Guid.Parse("65dabc50-a9b7-4733-83a4-b14842922157"), Nombre = "Apple" },
                new Marca(){ Id = Guid.Parse("d6ac4586-a379-44ad-ad75-a4a238a6cfb5"), Nombre = "Sony" },
                new Marca(){ Id = Guid.Parse("46da45c1-b131-4afb-98c5-28c280140b1e"), Nombre = "Bose" },
            };
        public List<Marca> Marcas
        {
            get
            {
                if (_marcas == null)
                {
                    _marcas = new List<Marca>();
                }
                return _marcas;
            }
        }

        private List<SubCategoria> _subCategorias = new List<SubCategoria>()
            {
                new SubCategoria(){ Id = Guid.Parse("9a7d62ea-6901-427e-8e9a-e52c43636336"), Nombre = "Audífonos" },
                new SubCategoria(){ Id = Guid.Parse("d5618086-cf61-46ea-8713-a6bb70964df2"), Nombre = "Mini Componentes" },
                new SubCategoria(){ Id = Guid.Parse("4d1ce933-969e-4ffb-98d1-b36aba122be3"), Nombre = "Televisores LED" },
                new SubCategoria(){ Id = Guid.Parse("aec2e3b5-050f-42d4-a07d-ce2891e63080"), Nombre = "Notebook Gamer" },
                new SubCategoria(){ Id = Guid.Parse("3a5f7f0f-5b31-452e-9da2-e2e23eb45864"), Nombre = "Smartphone" },
            };
        public List<SubCategoria> SubCategorias
        {
            get
            {
                if (_subCategorias == null)
                {
                    _subCategorias = new List<SubCategoria>();
                }
                return _subCategorias;
            }
        }
    }
}

