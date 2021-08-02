using MantenedorProductos.WIN.VModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MantenedorProductos.WIN.Mantenedores
{
    public partial class Frm_Categorias : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_Categorias()
        {
            InitializeComponent();
            dgvCategorias.AutoGenerateColumns = false;
            BuscarSubCategorias();
        }

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        #region CRUD
        public void Agregar(CategoriaVM categoria)
        {
            var request = new RestRequest($"api/categorias", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(categoria);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                Nombre = string.Empty;
                cmbSubCategoria.SelectedIndex = 0;
                Buscar();
                
                MessageBox.Show("La Categoría se ha agregado correctamente.",
                                          "Mantenedor de Categorías",
                                          MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show(response.Content,
                                          "Mantenedor de Categorías",
                                          MessageBoxButtons.OK);
            }
        }
        public void Eliminar(Guid? idCategoria)
        {
            if (_client != null && (idCategoria != null && idCategoria != Guid.Empty))
            {
                var request = new RestRequest($"api/categorias/" + idCategoria, Method.DELETE);
                var response = _client.Execute(request);
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
                {
                    Buscar();
                }
                else
                {
                    MessageBox.Show(response.Content,
                                       "Mantenedor de Categorías",
                                       MessageBoxButtons.OK);
                }
            }
        }
        public void Buscar()
        {
            var request = new RestRequest($"api/categorias", Method.GET);
            var response = _client.Execute(request);
            Categorias = JsonConvert.DeserializeObject<List<CategoriaVM>>(response.Content);
        }        
        public void BuscarSubCategorias()
        {
            var request = new RestRequest($"api/subcategorias", Method.GET);
            var response = _client.Execute(request);
            SubCategorias = JsonConvert.DeserializeObject<List<SubCategoriaVM>>(response.Content);
        }
        #endregion

        #region PROPERTIES
        public string Nombre { get => txtCategoriasNombre.Text; set { txtCategoriasNombre.Text = value; } }
        public Guid? IdSubCategoria
        {
            get { 
                if (cmbSubCategoria.SelectedValue != null)
                {
                    return Guid.Parse(cmbSubCategoria.SelectedValue.ToString());
                }
                else {
                    return null;
                } 
            }            
            
            set => cmbSubCategoria.SelectedIndex = 0;
        }
        public List<SubCategoriaVM> SubCategorias
        {
            get => cmbSubCategoria.DataSource != null ? (List<SubCategoriaVM>)cmbSubCategoria.DataSource : new List<SubCategoriaVM>();
            set
            {
                cmbSubCategoria.DisplayMember = "Nombre";
                cmbSubCategoria.ValueMember = "Id";

                if (value != null)
                {
                    var subCategorias = new List<SubCategoriaVM>() { new SubCategoriaVM() { Id = null, Nombre = "Seleccione" } };
                    subCategorias.AddRange(value);
                    cmbSubCategoria.DataSource = subCategorias;
                }
            }
        }
        public List<CategoriaVM> Categorias
        {
            get => dgvCategorias.DataSource != null ? (List<CategoriaVM>)dgvCategorias.DataSource : new List<CategoriaVM>();
            set => dgvCategorias.DataSource = value;
        }
        #endregion

        #region HANDLERS
        private void btnCategoriasAgregar_Click(object sender, EventArgs e)
        {
            Agregar(new CategoriaVM() { Id = null, Nombre = Nombre, IdSubCategoria = IdSubCategoria });        
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.DataSource == null)
                return;
            if (e.RowIndex != -1)
            {
                var item = (CategoriaVM)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
                switch (e.ColumnIndex)
                {
                    case 4:
                        //var frm = Application.OpenForms.OfType<Frm_Principal>().FirstOrDefault();
                        Frm_Categorias_Editar f = new Frm_Categorias_Editar(item);
                        //f.MdiParent = this.MdiParent;
                        switch (f.ShowDialog())
                        {
                            case DialogResult.OK:
                                Buscar();
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                        break;
                    case 5:
                        DialogResult confirmar = MessageBox.Show("¿Desea eliminar la Categoria seleccionada? " + item.Nombre + ".",
                                       "Mantenedor de Categorías",
                                       MessageBoxButtons.YesNo);
                        if (confirmar.Equals(DialogResult.Yes))
                        {
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
