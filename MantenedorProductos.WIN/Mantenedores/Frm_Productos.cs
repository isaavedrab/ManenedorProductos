using MantenedorProductos.LIB.Modelos;
using MantenedorProductos.WIN.VModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MantenedorProductos.WIN.Mantenedores
{
    public partial class Frm_Productos : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_Productos()
        {
            InitializeComponent();            
            dgvProductos.AutoGenerateColumns = false;
            BuscarMarcas();
            BuscarCategorias();
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            Buscar();            
        }

        #region CRUD
        public void Agregar(Producto producto) 
        {                        
            var request = new RestRequest($"api/productos", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(producto);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                Limpiar();
                Buscar();
                
                MessageBox.Show("El Producto se ha agregado correctamente.",
                                          "Mantenedor de Productos",
                                          MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show(response.Content,
                                      "Mantenedor de Productos",
                                      MessageBoxButtons.OK);
            }

        }                
        public void Eliminar(Guid? idProducto) 
        {
            if (_client != null && (idProducto != null && idProducto != Guid.Empty)) {
                var request = new RestRequest($"api/productos/" + idProducto, Method.DELETE);
                var response = _client.Execute(request);
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
                {
                    Buscar();
                }
                else {
                    MessageBox.Show(response.Content,
                                      "Mantenedor de Productos",
                                      MessageBoxButtons.OK);
                }
            }
        }
        public void Buscar()
        {
            var request = new RestRequest($"api/productos", Method.GET);
            var response = _client.Execute(request);
            Productos = JsonConvert.DeserializeObject<List<ProductoVM>>(response.Content);            
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
        private void Limpiar()
        {
            var producto = new ProductoVM();
            Nombre = producto.Nombre;
            CodBarra = producto.CodBarra;
            Precio = producto.Precio;
            IdMarca = producto.IdMarca;
            IdCategoria = producto.IdCategoria;
        }
        #endregion

        #region PROPERTIES
        public string Nombre { get => txtProductosNombre.Text; set { txtProductosNombre.Text = value; } }
        public string CodBarra { get => txtProductosCodBar.Text; set { txtProductosCodBar.Text = value; } }
        public int Precio { get => int.Parse(nupProductos.Text); set => nupProductos.Text = value.ToString();}
        public Guid? IdMarca {
            get
            {
                if (cmbProductosMarca.SelectedValue != null)
                {
                    return Guid.Parse(cmbProductosMarca.SelectedValue.ToString());
                }
                else
                {
                    return null;
                }
            }          
            set => cmbProductosMarca.SelectedIndex = 0;
        }
        public Guid? IdCategoria {
            get
            {
                if (cmbProductosCategoria.SelectedValue != null)
                {
                    return Guid.Parse(cmbProductosCategoria.SelectedValue.ToString());
                }
                else
                {
                    return null;
                }
            }            
            set => cmbProductosCategoria.SelectedIndex = 0;
        }
        public List<MarcaVM> Marcas 
        {
            get => cmbProductosMarca.DataSource != null ? (List<MarcaVM>)cmbProductosMarca.DataSource : new List<MarcaVM>();
            set {
                cmbProductosMarca.DisplayMember = "Nombre";
                cmbProductosMarca.ValueMember = "Id";

                if (value != null) {
                    var marcas = new List<MarcaVM>() { new MarcaVM() { Id = null, Nombre = "Seleccione" } };
                    marcas.AddRange(value);
                    cmbProductosMarca.DataSource = marcas;                    
                }                
            }                
        }
        public List<CategoriaVM> Categorias 
        {
            get => cmbProductosCategoria.DataSource != null ? (List<CategoriaVM>)cmbProductosCategoria.DataSource : new List<CategoriaVM>();
            set {
                cmbProductosCategoria.DisplayMember = "Nombre";
                cmbProductosCategoria.ValueMember = "Id";

                if (value != null) {
                    var categorias = new List<CategoriaVM>() { new CategoriaVM() { Id = null, Nombre = "Seleccione" } };
                    categorias.AddRange(value);
                    cmbProductosCategoria.DataSource = categorias;                    
                }                
            }
        }
        public List<ProductoVM> Productos
        {
            get => dgvProductos.DataSource != null ? (List<ProductoVM>)dgvProductos.DataSource : new List<ProductoVM>();                
            set => dgvProductos.DataSource = value;
        }
        #endregion

        #region HANDLERES
        private void btnProductosAgregar_Click(object sender, EventArgs e)
        {
            var producto = new ProductoVM()
            {
                Id = null,
                Nombre = Nombre,
                CodBarra = CodBarra,
                Precio = Precio,
                IdCategoria = IdCategoria,
                IdMarca = IdMarca,
            };
            Agregar(producto);
        }
        private void btnProductosLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();           
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.DataSource == null)
                return;
            if (e.RowIndex != -1)
            {
                var item = (ProductoVM)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                switch (e.ColumnIndex)
                {
                    case 8:
                        //var frm = Application.OpenForms.OfType<Frm_Principal>().FirstOrDefault();
                        Frm_Productos_Editar f = new Frm_Productos_Editar(item);
                        //f.MdiParent = this.MdiParent;
                        switch (f.ShowDialog()) {
                            case DialogResult.OK:
                                Buscar();
                                break;
                            case DialogResult.Cancel:
                                break;
                        }                        
                        break;
                    case 9:
                        DialogResult confirmar = MessageBox.Show("¿Desea eliminar el Producto seleccionado?",
                                       "Mantenedor de Productos",
                                       MessageBoxButtons.YesNo);
                        if (confirmar.Equals(DialogResult.Yes)) {
                            Eliminar(item.Id);
                        }                                             
                        break;
                    default: break;
                }
            }
        }
        #endregion
    }
}
