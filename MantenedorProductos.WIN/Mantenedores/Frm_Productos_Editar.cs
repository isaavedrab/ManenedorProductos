using MantenedorProductos.LIB.Modelos;
using MantenedorProductos.WIN.VModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantenedorProductos.WIN.Mantenedores
{
    public partial class Frm_Productos_Editar : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");        
        public Frm_Productos_Editar(Producto producto)
        {
            InitializeComponent();
            BuscarMarcas();
            BuscarCategorias();
            Cargar(producto);
        }      
        public void Cargar(Producto producto) 
        {
            if (producto != null)
            {
                IdProducto = producto.Id;
                txtProductosEditarNombre.Text = producto.Nombre;
                txtProductosEditarCodBarra.Text = producto.CodBarra;
                nupProductosEditarPrecio.Value = producto.Precio;
                cmbProductosEditarMarca.SelectedValue = producto.IdMarca;
                cmbProductosEditarCategoria.SelectedValue = producto.IdCategoria;
            }
        }
        public void BuscarMarcas()
        {
            var request = new RestRequest($"api/marcas", Method.GET);
            var response = _client.Execute(request);
            Marcas = JsonConvert.DeserializeObject<List<MarcaVM>>(response.Content);
        }
        public void BuscarCategorias()
        {
            var request = new RestRequest($"api/categorias", Method.GET);
            var response = _client.Execute(request);
            Categorias = JsonConvert.DeserializeObject<List<CategoriaVM>>(response.Content);
        }
        
        public Guid? IdProducto { get; set; }
        public Guid? IdMarca
        {
            get => Guid.Parse(cmbProductosEditarMarca.SelectedValue.ToString());
            set => cmbProductosEditarMarca.SelectedIndex = 0;
        }
        public Guid? IdCategoria
        {
            get => Guid.Parse(cmbProductosEditarCategoria.SelectedValue.ToString());
            set => cmbProductosEditarCategoria.SelectedIndex = 0;
        }
        public List<MarcaVM> Marcas
        {
            get => cmbProductosEditarMarca.DataSource != null ? (List<MarcaVM>)cmbProductosEditarMarca.DataSource : new List<MarcaVM>();
            set
            {
                cmbProductosEditarMarca.DisplayMember = "Nombre";
                cmbProductosEditarMarca.ValueMember = "Id";

                if (value != null)
                {
                    var marcas = new List<MarcaVM>() { new MarcaVM() { Id = null, Nombre = "Seleccione" } };
                    marcas.AddRange(value);
                    cmbProductosEditarMarca.DataSource = marcas;
                }
            }
        }
        public List<CategoriaVM> Categorias
        {
            get => cmbProductosEditarCategoria.DataSource != null ? (List<CategoriaVM>)cmbProductosEditarCategoria.DataSource : new List<CategoriaVM>();
            set
            {
                cmbProductosEditarCategoria.DisplayMember = "Nombre";
                cmbProductosEditarCategoria.ValueMember = "Id";

                if (value != null)
                {
                    var categorias = new List<CategoriaVM>() { new CategoriaVM() { Id = null, Nombre = "Seleccione" } };
                    categorias.AddRange(value);
                    cmbProductosEditarCategoria.DataSource = categorias;
                }
            }
        }

        private void BtnProductosEditarActualizarClick(object sender, EventArgs e)
        {                                    
            var request = new RestRequest($"api/productos/" + IdProducto.Value.ToString(), Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(new {
                    Nombre = txtProductosEditarNombre.Text,
                    CodBarra = txtProductosEditarCodBarra.Text,
                    Precio = int.Parse(nupProductosEditarPrecio.Value.ToString()),
                    IdMarca = cmbProductosEditarMarca.SelectedValue,
                    IdCategoria = cmbProductosEditarCategoria.SelectedValue
                });                                
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                MessageBox.Show("El Producto se ha actualizado correctamente.",
                                              "Mantenedor de Productos",
                                              MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show(response.Content,
                                              "Mantenedor de Productos",
                                              MessageBoxButtons.OK);
            }
        }
        private void BtnProductosEditarCancelarClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
