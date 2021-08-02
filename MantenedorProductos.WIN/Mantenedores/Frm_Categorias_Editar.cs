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
    public partial class Frm_Categorias_Editar : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_Categorias_Editar(CategoriaVM categoria)
        {
            InitializeComponent();
            BuscarSubCategorias();
            Cargar(categoria);
        }
        public void Cargar(CategoriaVM categoria)
        {
            if (categoria != null)
            {
                IdCategoria = categoria.Id;
                txtCategoriasEditarNombre.Text = categoria.Nombre;                
                cmbCategoriasEditarSubCategoria.SelectedValue = categoria.IdSubCategoria;
            }
        }
        public void BuscarSubCategorias()
        {
            var request = new RestRequest($"api/subcategorias", Method.GET);
            var response = _client.Execute(request);
            SubCategorias = JsonConvert.DeserializeObject<List<SubCategoriaVM>>(response.Content);
        }

        public Guid? IdCategoria { get; set; }
        public Guid? IdSubCategoria
        {
            get => Guid.Parse(cmbCategoriasEditarSubCategoria.SelectedValue.ToString());
            set => cmbCategoriasEditarSubCategoria.SelectedIndex = 0;
        }
        public List<SubCategoriaVM> SubCategorias
        {
            get => cmbCategoriasEditarSubCategoria.DataSource != null ? (List<SubCategoriaVM>)cmbCategoriasEditarSubCategoria.DataSource : new List<SubCategoriaVM>();
            set
            {
                cmbCategoriasEditarSubCategoria.DisplayMember = "Nombre";
                cmbCategoriasEditarSubCategoria.ValueMember = "Id";

                if (value != null)
                {
                    var subCategorias = new List<SubCategoriaVM>() { new SubCategoriaVM() { Id = null, Nombre = "Seleccione" } };
                    subCategorias.AddRange(value);
                    cmbCategoriasEditarSubCategoria.DataSource = subCategorias;
                }
            }
        }

        private void btnCategoriasEditarCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCategoriaEditarActualizar_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"api/categorias/" + IdCategoria.Value.ToString(), Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(new
            {
                Nombre = txtCategoriasEditarNombre.Text,
                IdSubCategoria = cmbCategoriasEditarSubCategoria.SelectedValue
            });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                MessageBox.Show("La Categoría se ha actualizado correctamente.",
                                              "Mantenedor de Categorías",
                                              MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Content,
                                              "Mantenedor de Categorías",
                                              MessageBoxButtons.OK);
            }            
        }
    }
}
